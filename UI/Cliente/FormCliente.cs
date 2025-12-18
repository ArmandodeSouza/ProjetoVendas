using Application.Interfaces;
using Application.Servivces;
using Domain.Entities;
using Infrastructure.Repositories;
using System.Windows.Forms;

namespace UI {
    public partial class FormCliente : Form {

        private readonly ClienteService _clienteService;

        private readonly BindingSource _bindingSource = new BindingSource();


        public FormCliente(ClienteService clienteService) {
            InitializeComponent();
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
        }

        private async void btnTelaCadastroCli_Click(object sender, EventArgs e) {
            using var formCadastroCli = new FormCadastroCli(_clienteService);

            formCadastroCli.ShowDialog();

            if (formCadastroCli.CadastroRealizadoComSucesso) {
                await CarregarClientesAsync();
            }
        }
        private void ConfigurarGrid() {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = _bindingSource;

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn {
                DataPropertyName = "Nome",
                HeaderText = "Nome"
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn {
                DataPropertyName = "Email",
                HeaderText = "Email"
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn {
                DataPropertyName = "Telefone",
                HeaderText = "Telefone"
            });


            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.RowHeadersVisible = false;
        }
        private async Task CarregarClientesAsync() {
            var clientes = await _clienteService.GetAllAsync();
            _bindingSource.DataSource = clientes;
        }


        private async void FormCliente_Load(object sender, EventArgs e) {
            ConfigurarGrid();
            _bindingSource.DataSource = await _clienteService.GetAllAsync();
        }

        private async void btnEditar_Click(object sender, EventArgs e) {
            if (dgvClientes.CurrentRow == null) {
                MessageBox.Show("Selecione um cliente para editar.");
                return;
            }

            var clienteSelecionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            using var formEdicao = new FormCadastroCli(_clienteService, clienteSelecionado);

            formEdicao.ShowDialog();

            if (formEdicao.CadastroRealizadoComSucesso) {
                await CarregarClientesAsync();
            }
        }

        private async void btnExcluirCli_Click(object sender, EventArgs e) {
            if (dgvClientes.CurrentRow == null) {
                MessageBox.Show("Selecione um cliente para excluir.");
                return;
            }

            var clienteSelecionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            var confirmacao = MessageBox.Show(
                $"Deseja realmente excluir o cliente \"{clienteSelecionado.Nome}\"?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao != DialogResult.Yes)
                return;

            try {
                await _clienteService.ExcluirAsync(clienteSelecionado.Id);
                await CarregarClientesAsync();
            } catch (Exception ex) {
                MessageBox.Show(
                    $"Erro ao excluir cliente: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
