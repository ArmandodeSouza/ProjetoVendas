using Application.Interfaces;
using Application.Servivces;
using Domain.Entities;
using Infrastructure.Repositories;
using System.Windows.Forms;

namespace UI {
    public partial class FormCliente : Form {

        private readonly ClienteService _clienteService;

        private readonly BindingSource _bindingSource = new BindingSource();

        private Cliente? _clienteSelecionado;
        private List<Cliente> _clientes = new();
        private bool _digitacaoUsuario = true;

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

            _clientes = await _clienteService.GetAllAsync();
            _bindingSource.DataSource = await _clienteService.GetAllAsync();

            lstNome.DisplayMember = "Nome";
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

        private void txtPesquiNome_Click(object sender, EventArgs e) {

        }

        private async void btnPesquisarCli_Click(object sender, EventArgs e) {

            var nome = txtNome.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome)) {
                await CarregarClientesAsync();
                return;
            }

            var clientes = await _clienteService.NomeExisteAsync(nome);

            if (!clientes.Any()) {
                MessageBox.Show("Não existe cadastro com esse nome.");
                _bindingSource.DataSource = null;
                return;
            }

            _bindingSource.DataSource = clientes;
        }

        private async void txtNome_TextChanged(object sender, EventArgs e) {
            var texto = txtNome.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto)) {
                lstNome.Visible = false;
                return;
            }

            var filtrados = _clientes.Where(c => c.Nome.Contains(texto, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!filtrados.Any()) {
                lstNome.Visible = false;
                return;
            }

            lstNome.DataSource = filtrados;
            lstNome.Visible = true;
        }

        private void lstNome_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void txtNome_Click(object sender, EventArgs e) {
            if (lstNome.SelectedItem is not Cliente cliente)
                return;

            _clienteSelecionado = cliente;

            txtNome.Text = cliente.Nome;
            lstNome.Text = cliente.Nome;
            lstNome.Visible = false;
        }
    }
}
