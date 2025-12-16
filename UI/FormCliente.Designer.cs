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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txtPesquiNome = new TextBox();
            btnPesquisarCli = new Button();
            btnExcluirCli = new Button();
            btnEditarCli = new Button();
            btnTelaCadastroCli = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 15);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 1;
            label1.Text = "Projeto Vendas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(797, 277);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 92);
            label2.Name = "label2";
            label2.Size = new Size(54, 18);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // txtPesquiNome
            // 
            txtPesquiNome.Location = new Point(70, 87);
            txtPesquiNome.Name = "txtPesquiNome";
            txtPesquiNome.Size = new Size(310, 23);
            txtPesquiNome.TabIndex = 3;
            // 
            // btnPesquisarCli
            // 
            btnPesquisarCli.Location = new Point(399, 86);
            btnPesquisarCli.Name = "btnPesquisarCli";
            btnPesquisarCli.Size = new Size(75, 23);
            btnPesquisarCli.TabIndex = 4;
            btnPesquisarCli.Text = "Pesquisar";
            btnPesquisarCli.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCli
            // 
            btnExcluirCli.Location = new Point(713, 415);
            btnExcluirCli.Name = "btnExcluirCli";
            btnExcluirCli.Size = new Size(75, 23);
            btnExcluirCli.TabIndex = 5;
            btnExcluirCli.Text = "Excluir";
            btnExcluirCli.UseVisualStyleBackColor = true;
            // 
            // btnEditarCli
            // 
            btnEditarCli.Location = new Point(622, 415);
            btnEditarCli.Name = "btnEditarCli";
            btnEditarCli.Size = new Size(75, 23);
            btnEditarCli.TabIndex = 6;
            btnEditarCli.Text = "Editar";
            btnEditarCli.UseVisualStyleBackColor = true;
            // 
            // btnTelaCadastroCli
            // 
            btnTelaCadastroCli.Location = new Point(10, 415);
            btnTelaCadastroCli.Name = "btnTelaCadastroCli";
            btnTelaCadastroCli.Size = new Size(75, 23);
            btnTelaCadastroCli.TabIndex = 7;
            btnTelaCadastroCli.Text = "Cadastrar";
            btnTelaCadastroCli.UseVisualStyleBackColor = true;
            btnTelaCadastroCli.Click += btnTelaCadastroCli_Click_1;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTelaCadastroCli);
            Controls.Add(btnEditarCli);
            Controls.Add(btnExcluirCli);
            Controls.Add(btnPesquisarCli);
            Controls.Add(txtPesquiNome);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtPesquiNome;
        private Button btnPesquisarCli;
        private Button btnExcluirCli;
        private Button btnEditarCli;
        private Button btnTelaCadastroCli;
    }
}
