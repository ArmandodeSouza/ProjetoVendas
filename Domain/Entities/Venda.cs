using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Venda {
        public int Id { get; private set; }
        public int ClienteId { get; }
        public DateTime DataVenda { get; }
        public decimal Total { get; }
        public IReadOnlyCollection<VendaItem> Itens { get; }

        public Venda(int clienteId, IReadOnlyCollection<VendaItem> itens) {

            if (itens == null || !itens.Any())
                throw new DomainException("Venda sem itens");

            ClienteId = clienteId;
            DataVenda = DateTime.Now;
            Itens = itens;
            Total = itens.Sum(i => i.Subtotal);
        }
    }
}
