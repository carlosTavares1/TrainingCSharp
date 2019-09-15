using System;
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
        Dados dado;
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Convert.ToString(dado.I1));
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dado = new Dados();
        }
    }
}
