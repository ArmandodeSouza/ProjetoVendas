using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Factory;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Servivces {
    public class ProdutoService : IProdutoService {
        private readonly IProdutoRepository _repository;
        private readonly IProdutoFactory _factory;

        public ProdutoService(IProdutoRepository repository, IProdutoFactory factory) {
            _repository = repository;
            _factory = factory;
        }

        public async Task CadastrarAsync(string nome, string descricao, decimal preco, int estoque) {
            if (await _repository.NomeExisteAsync(nome))
                throw new ArgumentException("Já existe um produto com este nome.");

            var produto = _factory.Criar(nome, descricao, preco, estoque); // id será gerado no banco
            await _repository.AddAsync(produto);
        }

        public async Task AtualizarAsync(int id, string nome, string descricao, decimal preco, int estoque) {
            var produto = await _repository.GetByIdAsync(id);
            if (produto == null)
                throw new ArgumentException("Produto não encontrado.");
            if (await _repository.NomeExisteAsync(nome) && produto.Nome != nome)
                throw new ArgumentException("Já existe outro produto com este nome.");
            var produtoTemp = _factory.Criar(nome, descricao, preco, estoque);
            await _repository.UpdateAsync(produtoTemp);
        }

        public async Task ExcluirAsync(int id) {
            var produto = await _repository.GetByIdAsync(id);
            if (produto == null)
                throw new ArgumentException("Produto não encontrado.");

            await _repository.DeleteAsync(id);
        }

        public async Task<List<Produto>> GetAllAsync() {
            return await _repository.GetAllAsync();
        }

        public async Task<Produto?> GetByIdAsync(int id) {
            return await _repository.GetByIdAsync(id);
        }
    }

}

