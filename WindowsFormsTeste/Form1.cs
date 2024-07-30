using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void somar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textn1.Text);
            int n2 = int.Parse(textn2.Text);

            int resultado = n1 + n2;

            labelresultado.Text = resultado.ToString();

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            textn1.Clear();
            textn2.Clear();

            labelresultado.Text = "0";

            textn1.Focus();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
