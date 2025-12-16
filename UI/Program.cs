using Application.Servivces;
using Domain.Repositories;
using Infrastructure.Repositories;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace UI {
    static class Program {
        [STAThread]
        static void Main(string[] args) {
            ApplicationConfiguration.Initialize();

            IClienteRepository clienteRepository = new ClienteRepository();
            ClienteService clienteService = new ClienteService(clienteRepository);

            System.Windows.Forms.Application.Run(new FormPrincipal(clienteService));
        }
    }
}