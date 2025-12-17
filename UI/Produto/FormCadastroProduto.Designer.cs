namespace UI {
    partial class FormCadastroProduto {
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNomeProd = new TextBox();
            txtDescProd = new TextBox();
            txtPrecoProd = new TextBox();
            txtEstoqueProd = new TextBox();
            btnCancelCadProd = new Button();
            btnCadProd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 188);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 247);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Estoque";
            // 
            // txtNomeProd
            // 
            txtNomeProd.Location = new Point(109, 71);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(243, 27);
            txtNomeProd.TabIndex = 4;
            // 
            // txtDescProd
            // 
            txtDescProd.Location = new Point(109, 134);
            txtDescProd.Name = "txtDescProd";
            txtDescProd.Size = new Size(243, 27);
            txtDescProd.TabIndex = 5;
            // 
            // txtPrecoProd
            // 
            txtPrecoProd.Location = new Point(109, 181);
            txtPrecoProd.Name = "txtPrecoProd";
            txtPrecoProd.Size = new Size(243, 27);
            txtPrecoProd.TabIndex = 6;
            // 
            // txtEstoqueProd
            // 
            txtEstoqueProd.Location = new Point(109, 244);
            txtEstoqueProd.Name = "txtEstoqueProd";
            txtEstoqueProd.Size = new Size(243, 27);
            txtEstoqueProd.TabIndex = 7;
            // 
            // btnCancelCadProd
            // 
            btnCancelCadProd.Location = new Point(276, 425);
            btnCancelCadProd.Margin = new Padding(3, 4, 3, 4);
            btnCancelCadProd.Name = "btnCancelCadProd";
            btnCancelCadProd.Size = new Size(86, 31);
            btnCancelCadProd.TabIndex = 9;
            btnCancelCadProd.Text = "Cancelar";
            btnCancelCadProd.UseVisualStyleBackColor = true;
            btnCancelCadProd.Click += btnCancelCadProd_Click;
            // 
            // btnCadProd
            // 
            btnCadProd.Location = new Point(52, 425);
            btnCadProd.Margin = new Padding(3, 4, 3, 4);
            btnCadProd.Name = "btnCadProd";
            btnCadProd.Size = new Size(86, 31);
            btnCadProd.TabIndex = 8;
            btnCadProd.Text = "Salvar";
            btnCadProd.UseVisualStyleBackColor = true;
            btnCadProd.Click += btnCadProd_Click;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 503);
            Controls.Add(btnCancelCadProd);
            Controls.Add(btnCadProd);
            Controls.Add(txtEstoqueProd);
            Controls.Add(txtPrecoProd);
            Controls.Add(txtDescProd);
            Controls.Add(txtNomeProd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastroProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNomeProd;
        private TextBox txtDescProd;
        private TextBox txtPrecoProd;
        private TextBox txtEstoqueProd;
        private Button btnCancelCadProd;
        private Button btnCadProd;
    }
}