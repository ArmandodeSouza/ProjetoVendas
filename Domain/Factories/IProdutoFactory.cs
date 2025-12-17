using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Factory {
    public interface IProdutoFactory {
        Produto Criar(int id, string nome, string descricao, decimal preco, int estoque);
    }
}
