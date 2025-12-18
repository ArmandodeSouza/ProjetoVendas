using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Factory {
    public class ProdutoFactory : IProdutoFactory {
        public Produto Alterar(int id, string nome, string descricao, decimal preco, int estoque) {
            return new Produto(id, nome, descricao, preco, estoque);
        }

        public Produto Criar(string nome, string descricao, decimal preco, int estoque) {
            return new Produto(nome, descricao, preco, estoque);
        }
    }
}
