using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace ControleDeLuz
{
    public class ContaDB
    {
        private static readonly string dbPath = Path.Combine(AppContext.BaseDirectory, "contas.db");
        private static readonly string CONNECTION_STRING = $"Data Source={dbPath}";

        public ContaDB()
        {
            CriarTabelaSeNaoExistir();
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
                command.Parameters.AddWithValue("$tipo", conta.GetType().Name); // Salva "ContaResidencial" ou "ContaComercial"
                command.Parameters.AddWithValue("$consumidorId", conta.Titular.Id);

                command.ExecuteNonQuery();
            }
        }
    }
}
