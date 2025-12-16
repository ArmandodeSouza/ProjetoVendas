using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces {
    public interface IClienteService {
        Task CadastrarAsync(Cliente cliente);

        Task<List<Cliente>> GetAllAsync();

        Task AtualizarAsync(Cliente cliente);

        Task ExcluirAsync(int id);

    }
}
