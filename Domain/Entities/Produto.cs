using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Produto {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public int Estoque { get; private set; }

        internal Produto(
            string nome,
            string descricao,
            decimal preco,
            int estoque) {
            AlterarDados(nome, descricao, preco, estoque);
        }

        public void AlterarDados(
            string nome,
            string descricao,
            decimal preco,
            int estoque) {
            if (string.IsNullOrWhiteSpace(nome))
                throw new DomainException("Nome é obrigatório.");

            if (string.IsNullOrWhiteSpace(descricao))
                throw new DomainException("Descrição é obrigatória.");

            if (preco <= 0)
                throw new DomainException("Preço deve ser maior que zero.");

            if (estoque < 0)
                throw new DomainException("Estoque não pode ser negativo.");

            Nome = nome.Trim();
            Descricao = descricao.Trim();
            Preco = preco;
            Estoque = estoque;
        }

        public void AlterarEstoque(int novoEstoque) {
            if (novoEstoque < 0)
                throw new DomainException("Estoque não pode ser negativo.");

            Estoque = novoEstoque;
        }
    }
}
