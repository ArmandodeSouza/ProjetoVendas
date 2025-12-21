using Application;
using Application.Interfaces;
using Application.Servivces;
using Domain.Entities;
using Domain.Exceptions;
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
    public partial class FormCarrinho : Form {

        private readonly ClienteService _clienteService;

        private readonly ProdutoService _produtoService;

        private readonly VendaService _vendaService;

        private readonly BindingSource _bindingSource = new BindingSource();

        public FormCarrinho(ClienteService clienteService, ProdutoService produtoService, VendaService vendaService) {

            _clienteService = clienteService ?? throw new ArgumentException(nameof(clienteService));
            _produtoService = produtoService ?? throw new ArgumentException(nameof(produtoService));
            _vendaService = vendaService ?? throw new ArgumentException(nameof(vendaService));


            InitializeComponent();
            _vendaService = vendaService;
        }



        private List<Cliente> _clientes = new();
        private List<Produto> _produtos = new();
        private VendaService vendaService;
        private Carrinho _carrinho = new();

        private Cliente? _clienteSelecionado;
        private Produto? _produtoSelecionado;

        private void MostrarDadosProduto(Produto produto) {

            var quantidadeNoCarrinho = _carrinho.ObterQuantidadeNoCarrinho(produto.Id);
            var estoqueDisponivel = produto.Estoque - quantidadeNoCarrinho;

            txtValorItem.Text = produto.Preco.ToString("C");
            txtValorEmEstoque.Text = estoqueDisponivel.ToString();
            numQuantidade.Maximum = estoqueDisponivel;
            numQuantidade.Value = estoqueDisponivel > 0 ? 1 : 0;


        }
        private void LimparDadosProduto() {
            txtValorItem.Text = "R$ 0,00";
            txtValorEmEstoque.Text = "-";
            _produtoSelecionado = null;
            lstNomeProduto.SelectedIndex = -1;
        }
        private void LimparSelecaoProduto() {
            txtNomeProduto.Clear();
            numQuantidade.Value = 1;
            lstNomeProduto.SelectedIndex = -1;

            LimparDadosProduto();

        }


        private void ConfigurarGrid() {
            dgvCarrinho.AutoGenerateColumns = false;
            dgvCarrinho.DataSource = _bindingSource;

            dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn {
                DataPropertyName = "NomeProduto",
                HeaderText = "Produto"
            });

            dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn {
                DataPropertyName = "Quantidade",
                HeaderText = "Qtde"
            });

            dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn {
                DataPropertyName = "PrecoUnitario",
                HeaderText = "Preço"
            });
            dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn {
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal"
            });


            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrinho.RowHeadersVisible = false;

            dgvCarrinho.AutoGenerateColumns = false;
            dgvCarrinho.ReadOnly = true;
            dgvCarrinho.AllowUserToAddRows = false;
            dgvCarrinho.AllowUserToDeleteRows = false;
        }

        private async void FormCarrinho_Load(object sender, EventArgs e) {
            _clientes = await _clienteService.GetAllAsync();
            _produtos = await _produtoService.GetAllAsync();

            lstNomeCliente.DisplayMember = "Nome";

            lstNomeProduto.DisplayMember = "Nome";

            txtValorEmEstoque.Text = "0";
            txtValorItem.Text = "R$ 0,00";

            ConfigurarGrid();

        }

        private void AtualizarGrid() {
            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = _carrinho.Itens.ToList();
        }

        private void AtualizarTotal() {
            lblTotal.Text = _carrinho.Total.ToString("C");
        }
        private void btnAdicionarItem_Click(object sender, EventArgs e) {

            if (_clienteSelecionado == null) {
                MessageBox.Show("Selecione um cliente");
                return;
            }

            if (_produtoSelecionado == null) {
                MessageBox.Show("Selecione um produto");
                return;
            }

            try {
                _carrinho.AdicionarItem(
                    _produtoSelecionado,
                    (int)numQuantidade.Value
                );
                AtualizarGrid();
                AtualizarTotal();
                LimparSelecaoProduto();
                txtNomeCliente.Enabled = false;
                lstNomeCliente.SelectedIndex = -1;

            } catch (DomainException ex) {
                MessageBox.Show(ex.Message);
            }
        }



        private void txtNomeCliente_TextChanged(object sender, EventArgs e) {
            var texto = txtNomeCliente.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto)) {
                lstNomeCliente.Visible = false;
                return;
            }

            var filtrados = _clientes.Where(c => c.Nome.Contains(texto, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!filtrados.Any()) {
                lstNomeCliente.Visible = false;
                return;
            }

            lstNomeCliente.DataSource = filtrados;
            lstNomeCliente.Visible = true;


        }

        private void txtNomeCliente_Click(object sender, EventArgs e) {
            if (lstNomeCliente.SelectedItem is not Cliente cliente)
                return;

            _clienteSelecionado = cliente;

            txtNomeCliente.Text = cliente.Nome;
            lstNomeCliente.Visible = false;


        }



        private void txtNomeProduto_TextChanged(object sender, EventArgs e) {
            var texto = txtNomeProduto.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto)) {
                lstNomeProduto.Visible = false;
                LimparDadosProduto();
                return;
            }

            var filtrados = _produtos.Where(c => c.Nome.Contains(texto, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!filtrados.Any()) {
                lstNomeProduto.Visible = false;
                LimparDadosProduto();
                return;
            }

            lstNomeProduto.DataSource = filtrados;
            lstNomeProduto.Visible = true;
        }

        private void FormCarrinho_Click(object sender, EventArgs e) {

        }

        private async void txtNomeProduto_Click(object sender, EventArgs e) {
            if (lstNomeProduto.SelectedItem is not Produto produto)
                return;


            _produtoSelecionado = produto;

            txtNomeProduto.Text = produto.Nome;
            lstNomeProduto.Visible = false;

            MostrarDadosProduto(produto);

            _produtos = await _produtoService.GetAllAsync();


        }




        private void numQuantidade_ValueChanged(object sender, EventArgs e) {
            if (_produtoSelecionado == null) {
                txtValorItem.Text = "R$ 0,00";
                return;
            }

            var quantidade = (int)numQuantidade.Value;
            var subtotal = _produtoSelecionado.Preco * quantidade;

            txtValorItem.Text = subtotal.ToString("C");

        }

        private void btnRemover_Click(object sender, EventArgs e) {
            if (dgvCarrinho.SelectedRows.Count == 0) {
                MessageBox.Show("Selecione um item para remover");
                return;
            }

            var itemSelecionado = dgvCarrinho.SelectedRows[0].DataBoundItem as VendaItem;

            if (itemSelecionado == null)
                return;

            _carrinho.RemoverItem(itemSelecionado);

            AtualizarGrid();
            AtualizarTotal();

            if (_carrinho.Itens.Count == 0) {
                txtNomeCliente.Enabled = true;
                _clienteSelecionado = null;
                txtNomeCliente.Clear();
            }
        }

        private async Task NovaVenda() {

            _clienteSelecionado = null;
            _carrinho = new Carrinho();

            txtNomeCliente.Clear();
            txtNomeCliente.Enabled = true;

            dgvCarrinho.DataSource = null;
            lblTotal.Text = "R$ 0,00";

            _produtos = await _produtoService.GetAllAsync();
        }

        private async void btnConcluirPedido_ClickAsync(object sender, EventArgs e) {

            if (dgvCarrinho.Rows.Count == 0) {
                MessageBox.Show("Adicione itens ao carrinho antes de concluir o pedido.");
                return;
            }

            try {
                await _vendaService.ConcluirVendaAsync(
                    _clienteSelecionado!,
                    _carrinho
                );

                MessageBox.Show("Venda concluída com sucesso!");

                await NovaVenda();
            } catch (DomainException ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception) {
                MessageBox.Show("Erro ao concluir venda");
            }


        }
    }
}
