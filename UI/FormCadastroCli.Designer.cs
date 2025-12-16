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
            label1.Location = new Point(34, 53);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 104);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 152);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // txtCadNomeCli
            // 
            txtCadNomeCli.Location = new Point(99, 45);
            txtCadNomeCli.Name = "txtCadNomeCli";
            txtCadNomeCli.Size = new Size(221, 23);
            txtCadNomeCli.TabIndex = 3;
            // 
            // txtCadEmailCli
            // 
            txtCadEmailCli.Location = new Point(99, 96);
            txtCadEmailCli.Name = "txtCadEmailCli";
            txtCadEmailCli.Size = new Size(221, 23);
            txtCadEmailCli.TabIndex = 4;
            // 
            // mskCadTelCli
            // 
            mskCadTelCli.Location = new Point(99, 144);
            mskCadTelCli.Mask = "(99) 00000-0000";
            mskCadTelCli.Name = "mskCadTelCli";
            mskCadTelCli.Size = new Size(100, 23);
            mskCadTelCli.TabIndex = 5;
            // 
            // btnCadCli
            // 
            btnCadCli.Location = new Point(34, 311);
            btnCadCli.Name = "btnCadCli";
            btnCadCli.Size = new Size(75, 23);
            btnCadCli.TabIndex = 6;
            btnCadCli.Text = "Salvar";
            btnCadCli.UseVisualStyleBackColor = true;
            btnCadCli.Click += btnCadCli_Click;
            // 
            // btnCancelCadCli
            // 
            btnCancelCadCli.Location = new Point(230, 311);
            btnCancelCadCli.Name = "btnCancelCadCli";
            btnCancelCadCli.Size = new Size(75, 23);
            btnCancelCadCli.TabIndex = 7;
            btnCancelCadCli.Text = "Cancelar";
            btnCancelCadCli.UseVisualStyleBackColor = true;
            btnCancelCadCli.Click += btnCancelCadCli_Click;
            // 
            // FormCadastroCli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 377);
            Controls.Add(btnCancelCadCli);
            Controls.Add(btnCadCli);
            Controls.Add(mskCadTelCli);
            Controls.Add(txtCadEmailCli);
            Controls.Add(txtCadNomeCli);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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