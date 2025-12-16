namespace UI {
    partial class FormCliente {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel1 = new Panel();
            label1 = new Label();
            dgvClientes = new DataGridView();
            label2 = new Label();
            txtPesquiNome = new TextBox();
            btnPesquisarCli = new Button();
            btnExcluirCli = new Button();
            btnEditarCli = new Button();
            btnTelaCadastroCli = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 20);
            label1.Name = "label1";
            label1.Size = new Size(241, 39);
            label1.TabIndex = 1;
            label1.Text = "Projeto Vendas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(2, 164);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(911, 369);
            dgvClientes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 123);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // txtPesquiNome
            // 
            txtPesquiNome.Location = new Point(80, 116);
            txtPesquiNome.Margin = new Padding(3, 4, 3, 4);
            txtPesquiNome.Name = "txtPesquiNome";
            txtPesquiNome.Size = new Size(354, 27);
            txtPesquiNome.TabIndex = 3;
            // 
            // btnPesquisarCli
            // 
            btnPesquisarCli.Location = new Point(456, 115);
            btnPesquisarCli.Margin = new Padding(3, 4, 3, 4);
            btnPesquisarCli.Name = "btnPesquisarCli";
            btnPesquisarCli.Size = new Size(86, 31);
            btnPesquisarCli.TabIndex = 4;
            btnPesquisarCli.Text = "Pesquisar";
            btnPesquisarCli.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCli
            // 
            btnExcluirCli.Location = new Point(815, 553);
            btnExcluirCli.Margin = new Padding(3, 4, 3, 4);
            btnExcluirCli.Name = "btnExcluirCli";
            btnExcluirCli.Size = new Size(86, 31);
            btnExcluirCli.TabIndex = 5;
            btnExcluirCli.Text = "Excluir";
            btnExcluirCli.UseVisualStyleBackColor = true;
            btnExcluirCli.Click += btnExcluirCli_Click;
            // 
            // btnEditarCli
            // 
            btnEditarCli.Location = new Point(711, 553);
            btnEditarCli.Margin = new Padding(3, 4, 3, 4);
            btnEditarCli.Name = "btnEditarCli";
            btnEditarCli.Size = new Size(86, 31);
            btnEditarCli.TabIndex = 6;
            btnEditarCli.Text = "Editar";
            btnEditarCli.UseVisualStyleBackColor = true;
            btnEditarCli.Click += btnEditar_Click;
            // 
            // btnTelaCadastroCli
            // 
            btnTelaCadastroCli.Location = new Point(11, 553);
            btnTelaCadastroCli.Margin = new Padding(3, 4, 3, 4);
            btnTelaCadastroCli.Name = "btnTelaCadastroCli";
            btnTelaCadastroCli.Size = new Size(86, 31);
            btnTelaCadastroCli.TabIndex = 7;
            btnTelaCadastroCli.Text = "Cadastrar";
            btnTelaCadastroCli.UseVisualStyleBackColor = true;
            btnTelaCadastroCli.Click += btnTelaCadastroCli_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnTelaCadastroCli);
            Controls.Add(btnEditarCli);
            Controls.Add(btnExcluirCli);
            Controls.Add(btnPesquisarCli);
            Controls.Add(txtPesquiNome);
            Controls.Add(label2);
            Controls.Add(dgvClientes);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            Load += FormCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgvClientes;
        private Label label2;
        private TextBox txtPesquiNome;
        private Button btnPesquisarCli;
        private Button btnExcluirCli;
        private Button btnEditarCli;
        private Button btnTelaCadastroCli;
    }
}
