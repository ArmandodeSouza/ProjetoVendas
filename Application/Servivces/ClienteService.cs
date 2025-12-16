using Application.Interfaces;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Servivces {
    public class ClienteService : IClienteService {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository) {
            _repository = repository;
        }

        public async Task CadastrarAsync(Cliente cliente) {

            if (string.IsNullOrWhiteSpace(cliente.Nome))
                throw new Exception("Nome obrigatório");

            if (string.IsNullOrWhiteSpace(cliente.Email))
                throw new Exception("E-mail obrigatório");

            if (await _repository.EmailExisteAsync(cliente.Email))
                throw new Exception("E-mail já cadastrado");

            await _repository.AddAsync(cliente);
        }

        public async Task<List<Cliente>> GetAllAsync() {
            return await _repository.GetAllAsync();
        }

        public async Task AtualizarAsync(Cliente cliente) {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
                throw new Exception("Nome obrigatório");
            if (string.IsNullOrWhiteSpace(cliente.Email))
                throw new Exception("E-mail obrigatório");
            var clientesExistentes = await _repository.GetAllAsync();
            if (clientesExistentes.Any(c => c.Email == cliente.Email && c.Id != cliente.Id))
                throw new Exception("E-mail já cadastrado para outro cliente");
            await _repository.UpdateAsync(cliente);
        }

        public async Task ExcluirAsync(int id) {
            await _repository.DeleteAsync(id);
        }
    }
}
