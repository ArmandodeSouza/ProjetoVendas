using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories {
    public interface IClienteRepository : IRepository<Cliente> {
        Task<bool> EmailExisteAsync(string email);

        Task<List<Cliente>> NomeExisteAsync(string nome);

    }
}
