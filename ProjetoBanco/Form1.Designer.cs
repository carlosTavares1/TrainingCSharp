﻿namespace ProjetoBanco
{
    partial class Form1
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(119, 19);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(119, 54);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(119, 90);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(119, 132);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sacar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 224);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(98, 40);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 11;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Escolha a conta";
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(18, 361);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(75, 23);
            this.botaoNovaConta.TabIndex = 11;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 392);
            this.Controls.Add(this.botaoNovaConta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button botaoNovaConta;
    }
}

