using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Servivces {
    public class VendaService {

        private readonly IVendaRepository _vendaRepository;

        public VendaService(IVendaRepository vendaRepository) {
            _vendaRepository = vendaRepository;
        }

        public async Task ConcluirVendaAsync(
            Cliente cliente,
            Carrinho carrinho
        ) {

            if (cliente == null)
                throw new DomainException("Cliente inválido");

            if (!carrinho.Itens.Any())
                throw new DomainException("Carrinho vazio");

            var venda = new Venda(cliente.Id, carrinho.Itens);

            await _vendaRepository.InserirAsync(venda);
        }
    }
}
