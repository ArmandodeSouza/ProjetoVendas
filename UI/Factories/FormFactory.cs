using Application.Servivces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Relatorio;

namespace UI.Factories {
    public class FormFactory {

        private readonly ClienteService _clienteService;
        private readonly ProdutoService _produtoService;
        private readonly VendaService _vendaService;
        private readonly RelatorioService _relatorioService;

        public FormFactory(
            ClienteService clienteService,
            ProdutoService produtoService,
            VendaService vendaService,
            RelatorioService relatorioService) {
            _clienteService = clienteService;
            _produtoService = produtoService;
            _vendaService = vendaService;
            _relatorioService = relatorioService;

        }

        public FormCliente CriarFormCliente() =>
            new FormCliente(_clienteService);

        public FormProduto CriarFormProduto() =>
            new FormProduto(_produtoService);

        public FormCarrinho CriarFormCarrinho() =>
            new FormCarrinho(_clienteService, _produtoService, _vendaService);

        public FormRelatorio CriarFormRelatorio() =>
            new FormRelatorio(_relatorioService);
    }
}
