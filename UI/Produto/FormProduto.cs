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
    public partial class FormProduto : Form {

        private readonly ProdutoService _produtoService;

        private readonly BindingSource _bindingSource = new BindingSource();

        private Produto? _produtoSelecionado;
        private List<Produto> _produtos = new();

        public FormProduto(ProdutoService produtoService) {
            _produtoService = produtoService ?? throw new ArgumentException(nameof(produtoService));
            InitializeComponent();
        }

        private async void btnTelaCadaProd_Click(object sender, EventArgs e) {
            var formCadastroProduto = new FormCadastroProduto(_produtoService);
            formCadastroProduto.ShowDialog();

            if (formCadastroProduto.CadastroRealizadoComSucesso) {
                await CarregarProdutosAsync();
            }
        }






        private void ConfigurarGrid() {
            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.DataSource = _bindingSource;

            dgvProdutos.Columns.Add(new DataGridViewTextBoxColumn {
                DataPropertyName = "Nome",
                HeaderText = "Nome"
            });

            dgvProdutos.Columns.Add(new DataGridViewTextBoxColumn {
                DataPropertyName = "Descricao",
                HeaderText = "Descriçao"
            });

            dgvProdutos.Columns.Add(new DataGridViewTextBoxColumn {
                DataPropertyName = "Preco",
                HeaderText = "Preço"
            });
            dgvProdutos.Columns.Add(new DataGridViewTextBoxColumn {
                DataPropertyName = "Estoque",
                HeaderText = "Estoque"
            });


            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.RowHeadersVisible = false;
        }
        private async Task CarregarProdutosAsync() {
            var produtos = await _produtoService.GetAllAsync();
            _bindingSource.DataSource = produtos;
        }
        private async void FormProduto_Load(object sender, EventArgs e) {
            ConfigurarGrid();

            _produtos = await _produtoService.GetAllAsync();
            _bindingSource.DataSource = await _produtoService.GetAllAsync();

            lstProdutos.DisplayMember = "Nome";
        }

        private async void btnEditarProd_Click(object sender, EventArgs e) {
            if (dgvProdutos.CurrentRow == null) {
                MessageBox.Show("Selecione um produto para editar.");
                return;
            }

            var produtoSelecionado = (Produto)dgvProdutos.CurrentRow.DataBoundItem;
            using var formEdicaoProduto = new FormCadastroProduto(_produtoService, produtoSelecionado);

            formEdicaoProduto.ShowDialog();

            if (formEdicaoProduto.CadastroRealizadoComSucesso) {
                await CarregarProdutosAsync();
            }
        }

        private async void btnExcluirProd_Click(object sender, EventArgs e) {
            if (dgvProdutos.CurrentRow == null) {

                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            var produtoSelecionado = (Produto)dgvProdutos.CurrentRow.DataBoundItem;

            var confirmacao = MessageBox.Show(
                $"Tem certeza que deseja excluir o produto '{produtoSelecionado.Nome}'?",
                "Confirmação de exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao != DialogResult.Yes) {
                return;
            }
            try {
                await _produtoService.ExcluirAsync(produtoSelecionado.Id);
                await CarregarProdutosAsync();
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao excluir produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProduto_Click(object sender, EventArgs e) {
            if (lstProdutos.SelectedItem is not Produto produto)
                return;

            _produtoSelecionado = produto;

            txtProduto.Text = produto.Nome;
            lstProdutos.Text = produto.Nome;
            lstProdutos.Visible = false;
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void txtProduto_TextChanged(object sender, EventArgs e) {
            var texto = txtProduto.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto)) {
                lstProdutos.Visible = false;
                return;
            }

            var filtrados = _produtos.Where(c => c.Nome.Contains(texto, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!filtrados.Any()) {
                lstProdutos.Visible = false;
                return;
            }

            lstProdutos.DataSource = filtrados;
            lstProdutos.Visible = true;
        }

        private async void btnPesquisarCli_Click(object sender, EventArgs e) {
            var nome = txtProduto.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome)) {
                await CarregarProdutosAsync();
                return;
            }

            var produtos = await _produtoService.BuscaProdutoNomeAsync(nome);

            if (!produtos.Any()) {
                MessageBox.Show("Não existe cadastro com esse nome.");
                _bindingSource.DataSource = null;
                return;
            }

            _bindingSource.DataSource = produtos;
        }

        private void btnVoltar_Click(object sender, EventArgs e) {

            txtProduto.Clear();

            Form.ActiveForm.Close();
        }
    }
}