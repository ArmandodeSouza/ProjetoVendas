using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories {
    public interface IClienteRepository {
        Task<bool> EmailExisteAsync(string email);
        Task AddAsync(Cliente cliente);
        Task<List<Cliente>> GetAllAsync();
        Task UpdateAsync(Cliente cliente);
        Task DeleteAsync(int id);
    }
}
