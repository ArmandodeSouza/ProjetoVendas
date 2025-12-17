using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Factory {
    public class ProdutoFactory : IProdutoFactory {
        public Produto Criar(int id, string nome, string descricao, decimal preco, int estoque) {
            return new Produto(id, nome, descricao, preco, estoque);
        }
    }
}
