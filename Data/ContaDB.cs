using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace ControleDeLuz
{
    public class ContaDB
    {
        private static readonly string dbPath = Path.Combine(AppContext.BaseDirectory, "contas.db");
        private static readonly string CONNECTION_STRING = $"Data Source={dbPath}";
        private readonly IContaFactory _contaFactory;



        public ContaDB()
        {
            CriarTabelaSeNaoExistir();
            _contaFactory = new ContaFactory();
        }

        private void CriarTabelaSeNaoExistir()
        {
            using (var connection = new SqliteConnection(CONNECTION_STRING))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Contas (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        NumeroInstalacao INTEGER NOT NULL UNIQUE,
                        LeituraMesAnterior REAL NOT NULL,
                        LeituraMesAtual REAL NOT NULL,
                        TipoConta TEXT NOT NULL,
                        ConsumidorId INTEGER NOT NULL,
                        FOREIGN KEY (ConsumidorId) REFERENCES Consumidores(Id)
                    );
                ";
                command.ExecuteNonQuery();
            }
        }

        public void Adicionar(IConta conta)
        {
            using (var connection = new SqliteConnection(CONNECTION_STRING))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO Contas (NumeroInstalacao, LeituraMesAnterior, LeituraMesAtual, TipoConta, ConsumidorId) 
                    VALUES ($numInstalacao, $leituraAnt, $leituraAtual, $tipo, $consumidorId)";

                command.Parameters.AddWithValue("$numInstalacao", conta.NumeroInstalacao);
                command.Parameters.AddWithValue("$leituraAnt", conta.LeituraMesAnterior);
                command.Parameters.AddWithValue("$leituraAtual", conta.LeituraMesAtual);
                command.Parameters.AddWithValue("$tipo", conta.GetType().Name.Replace("Conta", "")); // Salva "ContaResidencial" ou "ContaComercial"
                command.Parameters.AddWithValue("$consumidorId", conta.Titular.Id);

                command.ExecuteNonQuery();
            }
        }

        public IConta BuscarPorUsuario(Consumidor consumidor) // Alterado para retornar IConta
        {
            using (var connection = new SqliteConnection(CONNECTION_STRING))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT Id, NumeroInstalacao, LeituraMesAnterior, LeituraMesAtual, TipoConta
                    FROM Contas 
                    WHERE ConsumidorId = $consumidorId";

                command.Parameters.AddWithValue("$consumidorId", consumidor.Id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read()) // Tenta ler a primeira (e única) linha
                    {
                        // Recupera os dados da linha atual
                        // int id = reader.GetInt32(reader.GetOrdinal("Id")); // Você pode usar se precisar do ID da conta do DB
                        int numeroInstalacao = reader.GetInt32(reader.GetOrdinal("NumeroInstalacao"));
                        double leituraMesAnterior = reader.GetDouble(reader.GetOrdinal("LeituraMesAnterior"));
                        double leituraMesAtual = reader.GetDouble(reader.GetOrdinal("LeituraMesAtual"));
                        string tipoContaString = reader.GetString(reader.GetOrdinal("TipoConta"));

                        try
                        {
                            // Usa a factory para criar a instância da conta
                            IConta conta = _contaFactory.CriarConta(
                                tipoContaString,
                                numeroInstalacao,
                                leituraMesAnterior,
                                leituraMesAtual,
                                consumidor
                            );  

                            return conta;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Erro ao criar conta do tipo '{tipoContaString}': {ex.Message}");
                            return null!;
                        }
                    }
                }
            }
            return null!; 
        }
    }
}
