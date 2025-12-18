using Application.Servivces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Factories {
    public class FormFactory {

        private readonly ClienteService _clienteService;
        private readonly ProdutoService _produtoService;

        public FormFactory(
            ClienteService clienteService,
            ProdutoService produtoService) {
            _clienteService = clienteService;
            _produtoService = produtoService;
        }

        public FormCliente CriarFormCliente() =>
            new FormCliente(_clienteService);

        public FormProduto CriarFormProduto() =>
            new FormProduto(_produtoService);
    }
}
