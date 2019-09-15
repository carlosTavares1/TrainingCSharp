using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBanco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            Conta novaConta = new ContaCorrente();
            novaConta.Titular = new Cliente(textoTitular.Text);
            novaConta.Numero = Convert.ToInt32(textoNumero.Text);

            this.formPrincipal.AdicionaConta(novaConta);

            
            MessageBox.Show("Cadastro realizado com sucesso!");
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {

        }

        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboTipoConta.Items.Add("Conta Poupança");
            comboTipoConta.Items.Add("Conta Corrente");
        }
    }
}
