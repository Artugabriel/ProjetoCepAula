namespace ProjetoCepAula
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            mskCEP = new MaskedTextBox();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            btnProcurar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 45);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "CEP:";
            // 
            // mskCEP
            // 
            mskCEP.Location = new Point(96, 37);
            mskCEP.Mask = "00000-999";
            mskCEP.Name = "mskCEP";
            mskCEP.Size = new Size(80, 23);
            mskCEP.TabIndex = 1;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(96, 104);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.ReadOnly = true;
            txtEndereco.Size = new Size(255, 23);
            txtEndereco.TabIndex = 2;
            txtEndereco.TextChanged += txtEndereco_TextChanged;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(96, 145);
            txtBairro.Name = "txtBairro";
            txtBairro.ReadOnly = true;
            txtBairro.Size = new Size(255, 23);
            txtBairro.TabIndex = 3;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(96, 187);
            txtCidade.Name = "txtCidade";
            txtCidade.ReadOnly = true;
            txtCidade.Size = new Size(138, 23);
            txtCidade.TabIndex = 4;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(96, 237);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(138, 23);
            txtEstado.TabIndex = 5;
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(276, 36);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(75, 23);
            btnProcurar.TabIndex = 6;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcurar);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtEndereco);
            Controls.Add(mskCEP);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox mskCEP;
        private TextBox txtEndereco;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private Button btnProcurar;
    }
}
