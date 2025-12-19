using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories {
    public interface IProdutoRepository : IRepository<Produto> {

        Task<bool> NomeExisteAsync(string nome);
        Task<decimal> ObterPrecoAsync(int id);
        Task<bool> TemEstoqueAsync(int produtoId, int quantidade);
        Task AtualizarEstoqueAsync(int produtoId, int quantidade);

    }
}
