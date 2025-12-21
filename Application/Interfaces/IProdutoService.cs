using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces {
    public interface IProdutoService {

        Task CadastrarAsync(string nome, string descricao, decimal preco, int estoque);
        Task AtualizarAsync(int id, string nome, string descricao, decimal preco, int estoque);
        Task ExcluirAsync(int id);
        Task<List<Produto>> GetAllAsync();
        Task<Produto?> GetByIdAsync(int id);

        Task<List<Produto>> BuscaProdutoNomeAsync(string nome);
    }
}
