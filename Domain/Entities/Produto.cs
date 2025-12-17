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

        internal Produto(string nome, string descricao, decimal preco, int estoque) {
            Validar(nome, preco, estoque);

            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
        }

        internal void Validar(string nome, string descricao, decimal preco, int estoque) {
            Validar(nome, preco, estoque);
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
        }

        private void Validar(string nome, decimal preco, int estoque) {
            if (string.IsNullOrWhiteSpace(nome))
                throw new DomainException("Nome do produto é obrigatório.");

            if (preco <= 0)
                throw new DomainException("Preço deve ser maior que zero.");

            if (estoque < 0)
                throw new DomainException("Estoque não pode ser negativo.");
        }

    }
}
