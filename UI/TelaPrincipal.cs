using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI {
    public partial class TelaPrincipal : Form {
        private readonly Application.Servivces.ClienteService _clienteService;

        public TelaPrincipal(Application.Servivces.ClienteService clienteService) {
            InitializeComponent();
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
        }

        private void btnAcessCli_Click(object sender, EventArgs e) {
            var formCliente = new FormCliente(_clienteService);
            formCliente.Show();
        }

        private void btnAcessProd_Click(object sender, EventArgs e) {
            var formaProduto = new FormProduto();
            formaProduto.Show();
        }

        private void btnAcessComp_Click(object sender, EventArgs e) {
            var formCarrinho = new FormCarrinho();
            formCarrinho.Show();
        }
    }
}
