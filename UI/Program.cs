using Application.Servivces;
using Domain.Repositories;
using Infrastructure.Repositories;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;
using UI.Factories;

namespace UI {
    static class Program {
        [STAThread]
        static void Main(string[] args) {


            ApplicationConfiguration.Initialize();

            var clienteService = new ClienteService(new ClienteRepository());
            var produtoService = new ProdutoService(new ProdutoRepository());
            var vendaService = new VendaService(new VendaRepository());

            var formFactory = new FormFactory(clienteService, produtoService, vendaService);

            System.Windows.Forms.Application.Run(new FormPrincipal(formFactory));
        }
    }
}