namespace UI.Relatorio {
    partial class FormRelatorio {
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
            mskInicio = new MaskedTextBox();
            mskFim = new MaskedTextBox();
            btnGerar = new Button();
            SuspendLayout();
            // 
            // mskInicio
            // 
            mskInicio.Location = new Point(97, 63);
            mskInicio.Mask = "00/00/0000";
            mskInicio.Name = "mskInicio";
            mskInicio.Size = new Size(100, 23);
            mskInicio.TabIndex = 0;
            mskInicio.ValidatingType = typeof(DateTime);
            // 
            // mskFim
            // 
            mskFim.Location = new Point(97, 118);
            mskFim.Mask = "00/00/0000";
            mskFim.Name = "mskFim";
            mskFim.Size = new Size(100, 23);
            mskFim.TabIndex = 1;
            mskFim.ValidatingType = typeof(DateTime);
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(97, 197);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(100, 23);
            btnGerar.TabIndex = 2;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // FormRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 354);
            Controls.Add(btnGerar);
            Controls.Add(mskFim);
            Controls.Add(mskInicio);
            Name = "FormRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskInicio;
        private MaskedTextBox mskFim;
        private Button btnGerar;
    }
}