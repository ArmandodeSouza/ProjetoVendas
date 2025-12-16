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
        private Cliente? _clienteEmEdicao;


        public bool CadastroRealizadoComSucesso { get; private set; }

        public FormCadastroCli(ClienteService clienteService) {
            InitializeComponent();
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
        }

        public FormCadastroCli(ClienteService clienteService, Cliente cliente) {
            InitializeComponent();
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
            _clienteEmEdicao = cliente;

            PreencherCamposParaEdicao();
        }
        private void PreencherCamposParaEdicao() {
            if (_clienteEmEdicao == null) return;

            txtCadNomeCli.Text = _clienteEmEdicao.Nome;
            txtCadEmailCli.Text = _clienteEmEdicao.Email;
            mskCadTelCli.Text = _clienteEmEdicao.Telefone;

            btnCadCli.Text = "Salvar alterações";
        }
        private void btnCancelCadCli_Click(object sender, EventArgs e) {
            txtCadNomeCli.Clear();
            txtCadEmailCli.Clear();
            mskCadTelCli.Clear();
            Close();
        }

        private async void btnCadCli_Click(object sender, EventArgs e) {
            try {
                if (_clienteEmEdicao == null) {
                    //CADASTRO
                    var cliente = new Cliente {
                        Nome = txtCadNomeCli.Text,
                        Email = txtCadEmailCli.Text,
                        Telefone = mskCadTelCli.Text
                    };

                    await _clienteService.CadastrarAsync(cliente);

                    MessageBox.Show(
                        "Cliente cadastrado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                } else {
                    //EDIÇÃO
                    _clienteEmEdicao.Nome = txtCadNomeCli.Text;
                    _clienteEmEdicao.Email = txtCadEmailCli.Text;
                    _clienteEmEdicao.Telefone = mskCadTelCli.Text;

                    await _clienteService.AtualizarAsync(_clienteEmEdicao);

                    MessageBox.Show(
                        "Cliente atualizado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                CadastroRealizadoComSucesso = true;
                Close();
            } catch (Exception ex) {
                MessageBox.Show(
                    $"Erro ao salvar cliente: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

