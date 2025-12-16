namespace UI {
    partial class TelaPrincipal {
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
            btnAcessCli = new Button();
            btnAcessProd = new Button();
            btnAcessComp = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 21);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 0;
            label1.Text = "Projeto Vendas";
            // 
            // btnAcessCli
            // 
            btnAcessCli.Location = new Point(70, 79);
            btnAcessCli.Name = "btnAcessCli";
            btnAcessCli.Size = new Size(75, 23);
            btnAcessCli.TabIndex = 1;
            btnAcessCli.Text = "Cliente";
            btnAcessCli.UseVisualStyleBackColor = true;
            btnAcessCli.Click += btnAcessCli_Click;
            // 
            // btnAcessProd
            // 
            btnAcessProd.Location = new Point(70, 124);
            btnAcessProd.Name = "btnAcessProd";
            btnAcessProd.Size = new Size(75, 23);
            btnAcessProd.TabIndex = 2;
            btnAcessProd.Text = "Produtos";
            btnAcessProd.UseVisualStyleBackColor = true;
            btnAcessProd.Click += btnAcessProd_Click;
            // 
            // btnAcessComp
            // 
            btnAcessComp.Location = new Point(70, 167);
            btnAcessComp.Name = "btnAcessComp";
            btnAcessComp.Size = new Size(75, 23);
            btnAcessComp.TabIndex = 3;
            btnAcessComp.Text = "Comprar";
            btnAcessComp.TextAlign = ContentAlignment.TopCenter;
            btnAcessComp.UseVisualStyleBackColor = true;
            btnAcessComp.Click += btnAcessComp_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 296);
            Controls.Add(btnAcessComp);
            Controls.Add(btnAcessProd);
            Controls.Add(btnAcessCli);
            Controls.Add(panel1);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnAcessCli;
        private Button btnAcessProd;
        private Button btnAcessComp;
    }
}