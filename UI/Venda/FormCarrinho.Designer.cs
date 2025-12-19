namespace UI {
    partial class FormCarrinho {
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numQuantidade = new NumericUpDown();
            txtValorItem = new TextBox();
            txtValorEmEstoque = new TextBox();
            dgvCarrinho = new DataGridView();
            btnAdicionarItem = new Button();
            btnCancelarPedido = new Button();
            btnConcluirPedido = new Button();
            txtNomeCliente = new TextBox();
            lstNomeCliente = new ListBox();
            txtNomeProduto = new TextBox();
            lstNomeProduto = new ListBox();
            label7 = new Label();
            lblTotal = new Label();
            btnRemover = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 82);
            panel1.TabIndex = 17;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 18;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 21;
            label3.Text = "Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 191);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 22;
            label4.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 191);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 23;
            label5.Text = "Quantidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(602, 191);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 24;
            label6.Text = "Em estoque";
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(414, 188);
            numQuantidade.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(45, 23);
            numQuantidade.TabIndex = 25;
            numQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantidade.ValueChanged += numQuantidade_ValueChanged;
            // 
            // txtValorItem
            // 
            txtValorItem.Location = new Point(515, 187);
            txtValorItem.Name = "txtValorItem";
            txtValorItem.Size = new Size(81, 23);
            txtValorItem.TabIndex = 26;
            // 
            // txtValorEmEstoque
            // 
            txtValorEmEstoque.Location = new Point(677, 187);
            txtValorEmEstoque.Name = "txtValorEmEstoque";
            txtValorEmEstoque.Size = new Size(42, 23);
            txtValorEmEstoque.TabIndex = 27;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(4, 241);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.Size = new Size(790, 133);
            dgvCarrinho.TabIndex = 28;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Location = new Point(724, 165);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(75, 23);
            btnAdicionarItem.TabIndex = 29;
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.UseVisualStyleBackColor = true;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // btnCancelarPedido
            // 
            btnCancelarPedido.Location = new Point(707, 416);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.Size = new Size(75, 23);
            btnCancelarPedido.TabIndex = 30;
            btnCancelarPedido.Text = "Cancelar";
            btnCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // btnConcluirPedido
            // 
            btnConcluirPedido.Location = new Point(626, 416);
            btnConcluirPedido.Name = "btnConcluirPedido";
            btnConcluirPedido.Size = new Size(75, 23);
            btnConcluirPedido.TabIndex = 31;
            btnConcluirPedido.Text = "Concluir";
            btnConcluirPedido.UseVisualStyleBackColor = true;
            btnConcluirPedido.Click += btnConcluirPedido_ClickAsync;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(62, 121);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(250, 23);
            txtNomeCliente.TabIndex = 1;
            txtNomeCliente.Click += txtNomeCliente_Click;
            txtNomeCliente.TextChanged += txtNomeCliente_TextChanged;
            // 
            // lstNomeCliente
            // 
            lstNomeCliente.FormattingEnabled = true;
            lstNomeCliente.IntegralHeight = false;
            lstNomeCliente.Location = new Point(62, 140);
            lstNomeCliente.Name = "lstNomeCliente";
            lstNomeCliente.Size = new Size(250, 48);
            lstNomeCliente.TabIndex = 33;
            lstNomeCliente.Visible = false;
            lstNomeCliente.Click += txtNomeCliente_Click;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(62, 187);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(250, 23);
            txtNomeProduto.TabIndex = 34;
            txtNomeProduto.Click += txtNomeProduto_Click;
            txtNomeProduto.TextChanged += txtNomeProduto_TextChanged;
            // 
            // lstNomeProduto
            // 
            lstNomeProduto.FormattingEnabled = true;
            lstNomeProduto.IntegralHeight = false;
            lstNomeProduto.Location = new Point(62, 209);
            lstNomeProduto.Name = "lstNomeProduto";
            lstNomeProduto.Size = new Size(250, 64);
            lstNomeProduto.TabIndex = 35;
            lstNomeProduto.Visible = false;
            lstNomeProduto.Click += txtNomeProduto_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(602, 388);
            label7.Name = "label7";
            label7.Size = new Size(61, 19);
            label7.TabIndex = 36;
            label7.Text = "TOTAL";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(677, 388);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 17);
            lblTotal.TabIndex = 37;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(724, 212);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 38;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // FormCarrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemover);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(lstNomeProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(lstNomeCliente);
            Controls.Add(txtNomeCliente);
            Controls.Add(btnConcluirPedido);
            Controls.Add(btnCancelarPedido);
            Controls.Add(btnAdicionarItem);
            Controls.Add(dgvCarrinho);
            Controls.Add(txtValorEmEstoque);
            Controls.Add(txtValorItem);
            Controls.Add(numQuantidade);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FormCarrinho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCarrinho";
            Load += FormCarrinho_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numQuantidade;
        private TextBox txtValorItem;
        private TextBox txtValorEmEstoque;
        private DataGridView dgvCarrinho;
        private Button btnAdicionarItem;
        private Button btnCancelarPedido;
        private Button btnConcluirPedido;
        private TextBox txtNomeCliente;
        private ListBox lstNomeCliente;
        private TextBox txtNomeProduto;
        private ListBox lstNomeProduto;
        private Label label7;
        private Label lblTotal;
        private Button btnRemover;
    }
}