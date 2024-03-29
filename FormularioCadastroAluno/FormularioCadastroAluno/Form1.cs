﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioCadastroAluno
{
    public partial class Form1 : Form
    {
        public List<Dados> lista;
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Informo o comando para recuperar a informação selecionada
            int indice = comboBox1.SelectedIndex;
            dado.idade = dado.PegaIdade(indice);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lista = new List<Dados>();

            comboBox1.Items.Add(14);
            comboBox1.Items.Add(15);
            comboBox1.Items.Add(16);
            comboBox1.Items.Add(17);
            comboBox1.Items.Add(18);
            comboBox1.Items.Add(19);
            comboBox1.Items.Add(20);
            comboBox1.Items.Add(21);
            comboBox1.Items.Add(22);
            comboBox1.Items.Add(23);
            comboBox1.Items.Add(24);
            comboBox1.Items.Add(25);
            comboBox1.Items.Add(26);
            comboBox1.Items.Add(27);
            comboBox1.Items.Add(28);
            comboBox1.Items.Add(29);
            comboBox1.Items.Add(30);
            comboBox1.Items.Add(31);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
             var nome = txtNome.Text;
            lista.Add(nome);
        }

        private void TxtEndereco_TextChanged(object sender, EventArgs e)
        {
            dado.Endereco = txtEndereco.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"O nome é {lista.Nome}\r\nO endereço é {dado.Endereco}\r\nA idade é {dado.idade}");
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
