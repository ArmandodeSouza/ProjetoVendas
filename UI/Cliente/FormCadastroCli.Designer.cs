namespace UI {
    partial class FormCadastroCli {
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
            txtCadNomeCli = new TextBox();
            txtCadEmailCli = new TextBox();
            mskCadTelCli = new MaskedTextBox();
            btnCadCli = new Button();
            btnCancelCadCli = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 71);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 139);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 203);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // txtCadNomeCli
            // 
            txtCadNomeCli.Location = new Point(113, 60);
            txtCadNomeCli.Margin = new Padding(3, 4, 3, 4);
            txtCadNomeCli.Name = "txtCadNomeCli";
            txtCadNomeCli.Size = new Size(252, 27);
            txtCadNomeCli.TabIndex = 3;
            // 
            // txtCadEmailCli
            // 
            txtCadEmailCli.Location = new Point(113, 128);
            txtCadEmailCli.Margin = new Padding(3, 4, 3, 4);
            txtCadEmailCli.Name = "txtCadEmailCli";
            txtCadEmailCli.Size = new Size(252, 27);
            txtCadEmailCli.TabIndex = 4;
            // 
            // mskCadTelCli
            // 
            mskCadTelCli.Location = new Point(113, 192);
            mskCadTelCli.Margin = new Padding(3, 4, 3, 4);
            mskCadTelCli.Mask = "(99) 00000-0000";
            mskCadTelCli.Name = "mskCadTelCli";
            mskCadTelCli.Size = new Size(114, 27);
            mskCadTelCli.TabIndex = 5;
            // 
            // btnCadCli
            // 
            btnCadCli.Location = new Point(39, 415);
            btnCadCli.Margin = new Padding(3, 4, 3, 4);
            btnCadCli.Name = "btnCadCli";
            btnCadCli.Size = new Size(86, 31);
            btnCadCli.TabIndex = 6;
            btnCadCli.Text = "Salvar";
            btnCadCli.UseVisualStyleBackColor = true;
            btnCadCli.Click += btnCadCli_Click;
            // 
            // btnCancelCadCli
            // 
            btnCancelCadCli.Location = new Point(263, 415);
            btnCancelCadCli.Margin = new Padding(3, 4, 3, 4);
            btnCancelCadCli.Name = "btnCancelCadCli";
            btnCancelCadCli.Size = new Size(86, 31);
            btnCancelCadCli.TabIndex = 7;
            btnCancelCadCli.Text = "Cancelar";
            btnCancelCadCli.UseVisualStyleBackColor = true;
            btnCancelCadCli.Click += btnCancelCadCli_Click;
            // 
            // FormCadastroCli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 503);
            Controls.Add(btnCancelCadCli);
            Controls.Add(btnCadCli);
            Controls.Add(mskCadTelCli);
            Controls.Add(txtCadEmailCli);
            Controls.Add(txtCadNomeCli);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCadastroCli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCadNomeCli;
        private TextBox txtCadEmailCli;
        private MaskedTextBox mskCadTelCli;
        private Button btnCadCli;
        private Button btnCancelCadCli;
    }
}