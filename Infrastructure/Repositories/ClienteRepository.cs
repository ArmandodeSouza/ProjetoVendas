using Domain.Entities;
using Domain.Repositories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories {
    public class ClienteRepository : IClienteRepository {
        public async Task<bool> EmailExisteAsync(string email) {
            const string sql =
                "SELECT 1 FROM clientes WHERE email = @email LIMIT 1";

            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(sql, (NpgsqlConnection)conn);
            cmd.Parameters.AddWithValue("email", email);

            var result = await cmd.ExecuteScalarAsync();
            return result != null;
        }
        public async Task AddAsync(Cliente entity) {
            const string sql = @"
                INSERT INTO clientes (nome, email, telefone)
                VALUES (@nome, @email, @telefone)";

            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(sql, (NpgsqlConnection)conn);
            cmd.Parameters.AddWithValue("nome", entity.Nome);
            cmd.Parameters.AddWithValue("email", entity.Email);
            cmd.Parameters.AddWithValue("telefone", entity.Telefone);

            await cmd.ExecuteNonQueryAsync();
        }
        public async Task<List<Cliente>> GetAllAsync() {
            const string sql =
                "SELECT id, nome, email, telefone FROM clientes ORDER BY nome";

            var clientes = new List<Cliente>();

            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(sql, (NpgsqlConnection)conn);
            await using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync()) {
                clientes.Add(new Cliente {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Email = reader.GetString(2),
                    Telefone = reader.GetString(3)
                });
            }

            return clientes;
        }
        public async Task UpdateAsync(Cliente cliente) {
            const string sql = @"
                UPDATE clientes
                SET nome = @nome,
                    email = @email,
                    telefone = @telefone
                WHERE id = @id";

            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(sql, (NpgsqlConnection)conn);
            cmd.Parameters.AddWithValue("id", cliente.Id);
            cmd.Parameters.AddWithValue("nome", cliente.Nome);
            cmd.Parameters.AddWithValue("email", cliente.Email);
            cmd.Parameters.AddWithValue("telefone", cliente.Telefone);

            await cmd.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync(int id) {
            const string sql = "DELETE FROM clientes WHERE id = @id";

            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(sql, (NpgsqlConnection)conn);
            cmd.Parameters.AddWithValue("id", id);

            await cmd.ExecuteNonQueryAsync();
        }

        public async Task<List<Cliente>> NomeExisteAsync(string nome) {

            const string sql = @"
                SELECT id, nome, email, telefone
                FROM clientes
                WHERE nome ILIKE @nome
                ORDER BY nome";

            using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(sql, (NpgsqlConnection)conn);

            cmd.Parameters.AddWithValue("@nome", $"%{nome}%");

            using var reader = await cmd.ExecuteReaderAsync();

            var clientes = new List<Cliente>();

            while (await reader.ReadAsync()) {
                clientes.Add(new Cliente {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Email = reader.GetString(2),
                    Telefone = reader.GetString(3)
                });
            }

            return clientes;
        }
        public Task<Cliente?> GetByIdAsync(int id) {
            throw new NotImplementedException();
        }

    }
}
