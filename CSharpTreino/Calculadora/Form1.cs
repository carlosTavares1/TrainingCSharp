using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Botao b;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUm_Click(object sender, EventArgs e)
        {
            txtResultado.SelectedText = Convert.ToString(b.b1);
            b.resultado += b.b1;
        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.b = new Botao();
        }

        private void BtnDois_Click(object sender, EventArgs e)
        {
            txtResultado.SelectedText = Convert.ToString(b.b2);
            b.resultado += b.b2;
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            txtResultado.SelectedText = Convert.ToString(b.b3);
            b.resultado += b.b3;
        }

        private void BtnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.SelectedText = Convert.ToString(b.b4);
            b.resultado += b.b4;
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.SelectedText = Convert.ToString(b.b5);
            b.resultado += b.b5;
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.SelectedText = Convert.ToString(b.b6);
            b.resultado += b.b6;
        }

        private void BtnSete_Click(object sender, EventArgs e)
        {
            txtResultado.SelectedText = Convert.ToString(b.b7);
            b.resultado += b.b7;
        }

        private void BtnOito_Click(object sender, EventArgs e)
        {
            txtResultado.SelectedText = Convert.ToString(b.b8);
            b.resultado += b.b8;
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            txtResultado.SelectedText = Convert.ToString(b.b9);
            b.resultado += b.b9;
        }

        private void BtnDez_Click(object sender, EventArgs e)
        {
            txtResultado.SelectedText = Convert.ToString(b.b0);
            b.resultado += b.b0;
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            char simbolo = '+';
            txtResultado.SelectedText = Convert.ToString(simbolo);
            b.Soma();
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(b.resultado);
            b.resultado = 0;
        }

        private void BtnApagaTudo_Click(object sender, EventArgs e)
        {
            txtResultado.Text = string.Empty;
            b.resultado = 0;
        }
    }
}
