using Application.DTO.Relatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories {
    public interface IRelatorioRepository {
        Task<List<RelatorioVendaDto>> ObterRelatorioVendasAsync(DateTime dataInicio, DateTime dataFim);
    }
}
