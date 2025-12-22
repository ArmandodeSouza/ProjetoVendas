using Domain.Entities;
using Domain.Factory;
using Domain.Repositories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories {
    public class ProdutoRepository : IProdutoRepository {

        private readonly IProdutoFactory _factory = new ProdutoFactory();

        public async Task AddAsync(Produto produto) {
            const string sql =
                "INSERT INTO produtos (nome, descricao, preco, estoque) " +
                "VALUES (@nome, @descricao, @preco, @estoque)";

            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new Npgsql.NpgsqlCommand(sql, (Npgsql.NpgsqlConnection)conn);
            cmd.Parameters.AddWithValue("nome", produto.Nome);
            cmd.Parameters.AddWithValue("descricao", produto.Descricao);
            cmd.Parameters.AddWithValue("preco", produto.Preco);
            cmd.Parameters.AddWithValue("estoque", produto.Estoque);

            await cmd.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync(int id) {
            const string sql =
                "DELETE FROM produtos WHERE id = @id";
            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new Npgsql.NpgsqlCommand(sql, (Npgsql.NpgsqlConnection)conn);
            cmd.Parameters.AddWithValue("id", id);

            await cmd.ExecuteNonQueryAsync();
        }

        public async Task<List<Produto>> GetAllAsync() {
            const string sql =
                "SELECT id, nome, descricao, preco, estoque FROM produtos ORDER BY nome";

            var produtos = new List<Produto>();

            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new Npgsql.NpgsqlCommand(sql, (Npgsql.NpgsqlConnection)conn);
            await using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync()) {
                var produto = _factory.Alterar(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetDecimal(3),
                    reader.GetInt32(4)
                );

                produtos.Add(produto);

            }
            return produtos;
        }

        public async Task<Produto?> GetByIdAsync(int id) {
            const string sql = "SELECT id, nome, descricao, preco, estoque FROM produtos WHERE id = @id";

            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(sql, (NpgsqlConnection)conn);
            cmd.Parameters.AddWithValue("id", id);

            await using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync()) {
                return _factory.Alterar(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetDecimal(3),
                    reader.GetInt32(4)
                );
            }

            return null;
        }

        public async Task<bool> NomeExisteAsync(string nome) {
            const string sql = "SELECT COUNT(1) FROM produtos WHERE nome = @nome";

            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(sql, (NpgsqlConnection)conn);
            cmd.Parameters.AddWithValue("nome", nome);

            var result = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(result) > 0;
        }

        public async Task UpdateAsync(Produto produto) {
            const string sql =
                "UPDATE produtos SET nome = @nome, descricao = @descricao, preco = @preco, estoque = @estoque " +
                "WHERE id = @id";

            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new Npgsql.NpgsqlCommand(sql, (Npgsql.NpgsqlConnection)conn);
            cmd.Parameters.AddWithValue("@id", produto.Id);
            cmd.Parameters.AddWithValue("nome", produto.Nome);
            cmd.Parameters.AddWithValue("descricao", produto.Descricao);
            cmd.Parameters.AddWithValue("preco", produto.Preco);
            cmd.Parameters.AddWithValue("estoque", produto.Estoque);

            await cmd.ExecuteNonQueryAsync();

        }

        public async Task<List<Produto>> BuscaProdutoAsync(string nome) {
            const string sql =
                "SELECT id, nome, descricao, preco, estoque FROM produtos WHERE nome ILIKE @nome ORDER BY nome";
            var produtos = new List<Produto>();
            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();
            await using var cmd = new Npgsql.NpgsqlCommand(sql, (Npgsql.NpgsqlConnection)conn);
            cmd.Parameters.AddWithValue("nome", $"%{nome}%");
            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync()) {
                var produto = _factory.Alterar(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetDecimal(3),
                    reader.GetInt32(4)
                );
                produtos.Add(produto);
            }
            return produtos;
        }
    }
}
