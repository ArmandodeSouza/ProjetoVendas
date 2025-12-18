namespace UI {
    partial class FormProduto {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnTelaCadaProd = new Button();
            btnEditarProd = new Button();
            btnExcluirProd = new Button();
            btnPesquisarCli = new Button();
            txtPesquiNome = new TextBox();
            label2 = new Label();
            dgvProdutos = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTelaCadaProd
            // 
            btnTelaCadaProd.Location = new Point(10, 417);
            btnTelaCadaProd.Name = "btnTelaCadaProd";
            btnTelaCadaProd.Size = new Size(75, 23);
            btnTelaCadaProd.TabIndex = 15;
            btnTelaCadaProd.Text = "Cadastrar";
            btnTelaCadaProd.UseVisualStyleBackColor = true;
            btnTelaCadaProd.Click += btnTelaCadaProd_Click;
            // 
            // btnEditarProd
            // 
            btnEditarProd.Location = new Point(606, 417);
            btnEditarProd.Name = "btnEditarProd";
            btnEditarProd.Size = new Size(75, 23);
            btnEditarProd.TabIndex = 14;
            btnEditarProd.Text = "Editar";
            btnEditarProd.UseVisualStyleBackColor = true;
            btnEditarProd.Click += btnEditarProd_Click;
            // 
            // btnExcluirProd
            // 
            btnExcluirProd.Location = new Point(705, 417);
            btnExcluirProd.Name = "btnExcluirProd";
            btnExcluirProd.Size = new Size(75, 23);
            btnExcluirProd.TabIndex = 13;
            btnExcluirProd.Text = "Excluir";
            btnExcluirProd.UseVisualStyleBackColor = true;
            btnExcluirProd.Click += btnExcluirProd_Click;
            // 
            // btnPesquisarCli
            // 
            btnPesquisarCli.Location = new Point(388, 89);
            btnPesquisarCli.Name = "btnPesquisarCli";
            btnPesquisarCli.Size = new Size(75, 23);
            btnPesquisarCli.TabIndex = 12;
            btnPesquisarCli.Text = "Pesquisar";
            btnPesquisarCli.UseVisualStyleBackColor = true;
            // 
            // txtPesquiNome
            // 
            txtPesquiNome.Location = new Point(66, 92);
            txtPesquiNome.Name = "txtPesquiNome";
            txtPesquiNome.Size = new Size(310, 23);
            txtPesquiNome.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 95);
            label2.Name = "label2";
            label2.Size = new Size(54, 18);
            label2.TabIndex = 10;
            label2.Text = "Nome:";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(3, 134);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(797, 277);
            dgvProdutos.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 82);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 27);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 2;
            label1.Text = "Projeto Vendas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnTelaCadaProd);
            Controls.Add(btnEditarProd);
            Controls.Add(btnExcluirProd);
            Controls.Add(btnPesquisarCli);
            Controls.Add(txtPesquiNome);
            Controls.Add(label2);
            Controls.Add(dgvProdutos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProduto";
            Load += FormProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTelaCadaProd;
        private Button btnEditarProd;
        private Button btnExcluirProd;
        private Button btnPesquisarCli;
        private TextBox txtPesquiNome;
        private Label label2;
        private DataGridView dgvProdutos;
        private Panel panel1;
        private Label label1;
    }
}