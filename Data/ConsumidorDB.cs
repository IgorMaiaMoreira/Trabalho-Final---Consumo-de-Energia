using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;

namespace ControleDeLuz
{

    /// Implementação para manipular dados de Consumidores usando SQLite.
    public class ConsumidorDB : IConsumidorDB
    {
        
        // Cria um caminho absoluto para o banco de dados na mesma pasta do executável.
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
                        TipoConsumidor TEXT NOT NULL
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
                command.CommandText = "INSERT INTO Consumidores (Nome, Documento, TipoConsumidor) VALUES ($nome, $documento, $tipo)";

                command.Parameters.AddWithValue("$nome", consumidor.Nome);
                command.Parameters.AddWithValue("$documento", consumidor.ObterDocumento());
                command.Parameters.AddWithValue("$tipo", consumidor.GetType().Name);

                command.ExecuteNonQuery();
            }
        }

        public Consumidor BuscarPorDocumento(string documento)
        {
            Consumidor consumidorEncontrado = null;

            using (var connection = new SqliteConnection(CONNECTION_STRING))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Nome, Documento, TipoConsumidor FROM Consumidores WHERE Documento = $documento";
                command.Parameters.AddWithValue("$documento", documento);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string tipoConsumidor = reader.GetString(3);

                        if (tipoConsumidor == nameof(PessoaFisica))
                        {
                            consumidorEncontrado = new PessoaFisica
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                CPF = reader.GetString(2)
                            };
                        }
                        else if (tipoConsumidor == nameof(PessoaJuridica))
                        {
                            consumidorEncontrado = new PessoaJuridica
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                CNPJ = reader.GetString(2)
                            };
                        }
                    }
                }
            }
            return consumidorEncontrado;
        }

        public List<Consumidor> ListarTodos()
        {
            var consumidores = new List<Consumidor>();
            // Implementar a lógica para ler todos os consumidores do banco aqui
            return consumidores;
        }
    }
}
