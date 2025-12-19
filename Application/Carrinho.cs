using Domain.Entities;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application {
    public class Carrinho {

        private readonly List<VendaItem> _itens = new();

        public IReadOnlyCollection<VendaItem> Itens => _itens;
        public decimal Total => _itens.Sum(i => i.Subtotal);

        public void AdicionarItem(Produto produto, int quantidade) {

            var itemExistente = _itens
        .FirstOrDefault(i => i.ProdutoId == produto.Id);

            var quantidadeTotal = quantidade +
                (itemExistente?.Quantidade ?? 0);

            if (quantidadeTotal > produto.Estoque)
                throw new DomainException("Quantidade maior que o estoque disponível");

            if (itemExistente == null) {
                _itens.Add(new VendaItem(
                    produto.Id,
                    produto.Nome,
                    quantidade,
                    produto.Preco
                ));
            } else {
                itemExistente.SomarQuantidade(quantidade);
            }
        }


        public void RemoverItem(VendaItem item) {
            _itens.Remove(item);
        }
        public int ObterQuantidadeNoCarrinho(int produtoId) {
            return _itens
                .Where(i => i.ProdutoId == produtoId)
                .Sum(i => i.Quantidade);
        }

    }
}
