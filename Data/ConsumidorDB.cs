using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; // Necessário para o método .Where()

namespace ControleDeLuz
{
    public class ConsumidorDB : IConsumidorDB
    {
        private static readonly string dbPath = Path.Combine(AppContext.BaseDirectory, "contas.db");
        private static readonly string CONNECTION_STRING = $"Data Source={dbPath}";

        public ConsumidorDB()
        {
            CriarBancoDeDadosSeNaoExistir();
        }

        private void CriarBancoDeDadosSeNaoExistir()
        {
            using (var connection = new SqliteConnection(CONNECTION_STRING))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Consumidores (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL,
                        Documento TEXT NOT NULL UNIQUE,
                        TipoConsumidor TEXT NOT NULL,
                        NumeroInstalacao INTEGER NOT NULL UNIQUE 
                    );
                ";
                command.ExecuteNonQuery();
            }
        }

        public void Adicionar(Consumidor consumidor)
        {
            using (var connection = new SqliteConnection(CONNECTION_STRING))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Consumidores (Nome, Documento, TipoConsumidor, NumeroInstalacao) VALUES ($nome, $documento, $tipo, $numInstalacao)";

                command.Parameters.AddWithValue("$nome", consumidor.Nome);
                command.Parameters.AddWithValue("$documento", consumidor.ObterDocumento());
                command.Parameters.AddWithValue("$tipo", consumidor.GetType().Name);
                command.Parameters.AddWithValue("$numInstalacao", consumidor.NumeroInstalacao);

                command.ExecuteNonQuery();
            }
        }

        public Consumidor BuscarPorDocumento(string documento)
        {
            // Limpa o documento de entrada para conter apenas dígitos.
            var documentoLimpo = new string(documento.Where(char.IsDigit).ToArray());
            if (string.IsNullOrEmpty(documentoLimpo))
            {
                return null!; // Retorna nulo se a entrada for inválida (ex: "abc")
            }

            Consumidor consumidorEncontrado = null!;
            using (var connection = new SqliteConnection(CONNECTION_STRING))
            {
                connection.Open();
                var command = connection.CreateCommand();
                
                command.CommandText = @"
                    SELECT Id, Nome, Documento, TipoConsumidor, NumeroInstalacao 
                    FROM Consumidores 
                    WHERE REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Documento, '.', ''), '-', ''), '/', ''), ' ', ''), ',', '') = $documento";
                
                command.Parameters.AddWithValue("$documento", documentoLimpo);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string tipoConsumidor = reader.GetString(3);
                        int id = reader.GetInt32(0);
                        string nome = reader.GetString(1);
                        string doc = reader.GetString(2);
                        int numeroInstalacao = reader.GetInt32(4);

                        if (tipoConsumidor == nameof(PessoaFisica))
                        {
                            consumidorEncontrado = new PessoaFisica { Id = id, Nome = nome, CPF = doc, NumeroInstalacao = numeroInstalacao };
                        }
                        else if (tipoConsumidor == nameof(PessoaJuridica))
                        {
                            consumidorEncontrado = new PessoaJuridica { Id = id, Nome = nome, CNPJ = doc, NumeroInstalacao = numeroInstalacao };
                        }
                    }
                }
            }
                return consumidorEncontrado;
        }

        public List<Consumidor> ListarTodos()
        {
            var consumidores = new List<Consumidor>();
            return consumidores;
        }
    }
}
