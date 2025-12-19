using Application.Servivces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Factories;

namespace UI {
    public partial class FormPrincipal : Form {
        private readonly FormFactory _formFactory;

        public FormPrincipal(FormFactory formFactory) {
            InitializeComponent();
            _formFactory = formFactory ?? throw new ArgumentNullException(nameof(formFactory));
        }

        private void btnAcessCli_Click(object sender, EventArgs e) {
            _formFactory.CriarFormCliente().Show();
        }

        private void btnAcessProd_Click(object sender, EventArgs e) {
            _formFactory.CriarFormProduto().Show();
        }

        private void btnAcessComp_Click(object sender, EventArgs e) {
            _formFactory.CriarFormCarrinho().Show();
        }


    }
}
