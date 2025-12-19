using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class VendaItem {
        public int ProdutoId { get; private set; }
        public string NomeProduto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal PrecoUnitario { get; private set; }
        public decimal Subtotal => Quantidade * PrecoUnitario;

        public VendaItem(int produtoId, string nomeProduto, int quantidade, decimal precoUnitario) {
            if (quantidade <= 0)
                throw new DomainException("Quantidade inválida");

            ProdutoId = produtoId;
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }

        public void SomarQuantidade(int quantidade) {
            Quantidade += quantidade;
        }
    }
}