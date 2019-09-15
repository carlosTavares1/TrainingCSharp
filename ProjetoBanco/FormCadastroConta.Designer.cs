namespace ProjetoBanco
{
    partial class FormCadastroConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboTipoConta = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(91, 33);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 2;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(91, 84);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 3;
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(6, 173);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastro.TabIndex = 4;
            this.botaoCadastro.Text = "Cadastrar";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboTipoConta);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Controls.Add(this.botaoCadastro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 202);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Conta";
            // 
            // comboTipoConta
            // 
            this.comboTipoConta.FormattingEnabled = true;
            this.comboTipoConta.Location = new System.Drawing.Point(91, 133);
            this.comboTipoConta.Name = "comboTipoConta";
            this.comboTipoConta.Size = new System.Drawing.Size(100, 21);
            this.comboTipoConta.TabIndex = 5;
            this.comboTipoConta.SelectedIndexChanged += new System.EventHandler(this.comboTipoConta_SelectedIndexChanged);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 232);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Button botaoCadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboTipoConta;
    }
}