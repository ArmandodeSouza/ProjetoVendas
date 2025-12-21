using Domain.Entities;
using Domain.Repositories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories {
    public class VendaRepository : IVendaRepository {
        public async Task<int> InserirAsync(Venda venda) {

            const string sqlVenda = @"
                INSERT INTO vendas (cliente_id, data_venda, total)
                VALUES (@cliente_id, @data_venda, @total)
                RETURNING id";

            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var transaction = await conn.BeginTransactionAsync();
            try {
                int vendaId;
                await using (var cmdVenda = new NpgsqlCommand(sqlVenda, (NpgsqlConnection)conn, (NpgsqlTransaction)transaction)) {
                    cmdVenda.Parameters.AddWithValue("cliente_id", venda.ClienteId);
                    cmdVenda.Parameters.AddWithValue("data_venda", venda.DataVenda);
                    cmdVenda.Parameters.AddWithValue("total", venda.Total);
                    vendaId = (int)await cmdVenda.ExecuteScalarAsync();
                }
                const string sqlItem = @"
                    INSERT INTO venda_itens (venda_id, produto_id, quantidade, preco_unitario)
                    VALUES (@venda_id, @produto_id, @quantidade, @preco_unitario)";
                foreach (var item in venda.Itens) {
                    await using var cmdItem = new NpgsqlCommand(sqlItem, (NpgsqlConnection)conn, (NpgsqlTransaction)transaction);
                    cmdItem.Parameters.AddWithValue("venda_id", vendaId);
                    cmdItem.Parameters.AddWithValue("produto_id", item.ProdutoId);
                    cmdItem.Parameters.AddWithValue("quantidade", item.Quantidade);
                    cmdItem.Parameters.AddWithValue("preco_unitario", item.PrecoUnitario);
                    await cmdItem.ExecuteNonQueryAsync();



                }

                var sqlEstoque = @"
                UPDATE produtos
                SET estoque = estoque - @quantidade
                WHERE id = @produto_id";
                foreach (var item in venda.Itens) {
                    await using var cmdEstoque = new NpgsqlCommand(sqlEstoque, (NpgsqlConnection)conn);
                    cmdEstoque.Parameters.AddWithValue("quantidade", item.Quantidade);
                    cmdEstoque.Parameters.AddWithValue("produto_id", item.ProdutoId);
                    await cmdEstoque.ExecuteNonQueryAsync();
                }

                await transaction.CommitAsync();

                return vendaId;
            } catch {
                await transaction.RollbackAsync();
                throw;
            }




        }

    }
}

