using Application.Servivces;
using Domain.Entities;
using Domain.Factory;
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
    public partial class FormCadastroProduto : Form {

        private readonly ProdutoService _produtoService;

        private Produto? _produtoEmEdicao;
        public bool CadastroRealizadoComSucesso { get; private set; }

        public FormCadastroProduto(ProdutoService produtoService) {
            InitializeComponent();
            _produtoService = produtoService ?? throw new ArgumentNullException(nameof(produtoService));

            PreencherCamposParaEdicao();
        }

        public FormCadastroProduto(ProdutoService produtoService, Produto produto) {
            InitializeComponent();
            _produtoService = produtoService ?? throw new ArgumentNullException(nameof(produtoService));
            _produtoEmEdicao = produto;
            PreencherCamposParaEdicao();
        }

        private void PreencherCamposParaEdicao() {
            if (_produtoEmEdicao == null) return;
            txtNomeProd.Text = _produtoEmEdicao.Nome;
            txtDescProd.Text = _produtoEmEdicao.Descricao;
            txtPrecoProd.Text = _produtoEmEdicao.Preco.ToString();
            txtEstoqueProd.Text = _produtoEmEdicao.Estoque.ToString();

            btnCadProd.Text = "Salvar alterações";
        }



        private async void btnCadProd_Click(object sender, EventArgs e) {

            try {
                if (_produtoEmEdicao == null) {
                    await _produtoService.CadastrarAsync(
                        txtNomeProd.Text,
                        txtDescProd.Text,
                        decimal.Parse(txtPrecoProd.Text),
                        int.Parse(txtEstoqueProd.Text)
                    );

                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {



                    await _produtoService.AtualizarAsync(
                        _produtoEmEdicao.Id,
                        txtNomeProd.Text,
                        txtDescProd.Text,
                        decimal.Parse(txtPrecoProd.Text),
                        int.Parse(txtEstoqueProd.Text)
                    );

                    MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                CadastroRealizadoComSucesso = true;
                Close();

            } catch (Exception ex) {

                MessageBox.Show(
                    $"Erro ao cadastrar/atualizar produto: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void btnCancelCadProd_Click(object sender, EventArgs e) {
            txtNomeProd.Clear();
            txtEstoqueProd.Clear();
            txtPrecoProd.Clear();
            txtEstoqueProd.Clear();
            Close();
        }



    }
}
