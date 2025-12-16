using Application.Interfaces;
using Application.Servivces;
using Domain.Entities;
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
    public partial class FormCadastroCli : Form {

        private readonly ClienteService _clienteService;

        public FormCadastroCli(ClienteService clienteService) {
            InitializeComponent();
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
        }

        private void btnCancelCadCli_Click(object sender, EventArgs e) {
            txtCadNomeCli.Clear();
            txtCadEmailCli.Clear();
            mskCadTelCli.Clear();
            Close();
        }

        private async void btnCadCli_Click(object sender, EventArgs e) {

            var cliente = new Cliente {
                Nome = txtCadNomeCli.Text,
                Email = txtCadEmailCli.Text,
                Telefone = mskCadTelCli.Text
            };

            try {
                await _clienteService.CadastrarAsync(cliente);

                MessageBox.Show(
                    "Cliente cadastrado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtCadNomeCli.Clear();
                txtCadEmailCli.Clear();
                mskCadTelCli.Clear();
                Close();
            } catch (Exception ex) {
                MessageBox.Show(
                    $"Erro ao cadastrar cliente: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

