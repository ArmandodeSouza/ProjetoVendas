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
        private readonly VendaService _vendaService;

        public FormFactory(
            ClienteService clienteService,
            ProdutoService produtoService,
            VendaService vendaService) {
            _clienteService = clienteService;
            _produtoService = produtoService;
            _vendaService = vendaService;
        }

        public FormCliente CriarFormCliente() =>
            new FormCliente(_clienteService);

        public FormProduto CriarFormProduto() =>
            new FormProduto(_produtoService);

        public FormCarrinho CriarFormCarrinho() =>
            new FormCarrinho(_clienteService, _produtoService, _vendaService);
    }
}
