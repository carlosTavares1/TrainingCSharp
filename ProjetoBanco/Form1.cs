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
    public partial class Form1 : Form
    {
        private Conta[] contas;
        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[100];


            Conta c2 = new ContaCorrente();
            c2.Titular = new Cliente("Mauricio");
            c2.Numero = 2;
            AdicionaConta(c2);

            Conta c3 = new ContaPoupanca();
            c3.Titular = new Cliente("Osni");
            c3.Numero = 3;
            AdicionaConta(c3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            double valorOperacao = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            double valorOperacao = Convert.ToDouble(textoValor.Text);
            try
            {
                selecionada.Saca(valorOperacao);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro liberado");
            }
            catch(SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo insuficiente!");
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("Não é possível realizar saque negativo.");
            }
            
        }


        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add("Titular: " + conta.Titular.Nome);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }
    }
}
