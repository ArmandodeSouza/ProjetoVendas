using Application.DTO.Relatorios;
using Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Servivces {
    public class RelatorioService {

        private readonly IRelatorioRepository _repository;

        public RelatorioService(IRelatorioRepository repository) {
            _repository = repository;
        }

        public async Task<List<RelatorioVendaDto>> GerarRelatorioVendasAsync(DateTime inicio, DateTime fim) {

            var dados = await _repository.ObterRelatorioVendasAsync(inicio, fim);

            return dados ?? new List<RelatorioVendaDto>();
        }
    }
}
