using Application.DTO.Relatorios;
using Application.Interfaces.Repositories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories {
    public class RelatorioRepository : IRelatorioRepository {

        public async Task<List<RelatorioVendaDto>> ObterRelatorioVendasAsync(DateTime dataInicio, DateTime dataFim) {
            const string sql = @"
                SELECT
                    v.id AS VendaId,
                    v.data_venda AS DataVenda,
                    c.nome AS Cliente,
                    v.total AS Total
                FROM vendas v
                JOIN clientes c ON c.id = v.cliente_id
                WHERE v.data_venda >= @inicio
                AND v.data_venda < (@fim + INTERVAL '1 day')
                ORDER BY c.nome, v.data_venda";

            await using var conn = DbConnectionFactory.Create();
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(sql, (NpgsqlConnection)conn);
            cmd.Parameters.AddWithValue("@inicio", dataInicio.Date);
            cmd.Parameters.AddWithValue("@fim", dataFim.Date);

            var lista = new List<RelatorioVendaDto>();
            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync()) {
                lista.Add(new RelatorioVendaDto {
                    VendaId = reader.GetInt32(0),
                    DataVenda = reader.GetDateTime(1),
                    Cliente = reader.GetString(2),
                    Total = reader.GetDecimal(3)
                });
            }

            return lista;
        }
    }
}
