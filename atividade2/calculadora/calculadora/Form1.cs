using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{

    
    public partial class Form1 : Form
    {
        double numeroumt;
        double numerodoist;
        double resultadot;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        { 

            resultadot = (numeroumt + numerodoist);
            resultado.Text = resultadot.ToString();
            
        }

        private void Numeroum_Validated(object sender, EventArgs e)
        {
            if( !double.TryParse(Numeroum.Text, out numeroumt))
                {
                MessageBox.Show("Digite um número");
                Numeroum.Focus();

            }
        }

        private void Numerodois_Validated(object sender, EventArgs e)
        {
            if ( !double.TryParse(Numerodois.Text, out numerodoist))
                {
                MessageBox.Show("Digite um número");
                Numerodois.Focus();

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            resultadot = (numeroumt * numerodoist);
            resultado.Text = resultadot.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            resultadot = (numeroumt - numerodoist);
            resultado.Text = resultadot.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (numerodoist == 0)
            {
                MessageBox.Show("Não é possível dividir por 0");
                Numerodois.Focus();
            }
            else {
                resultadot = (numeroumt / numerodoist);
                resultado.Text = resultadot.ToString();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja sair mesmo?",
                "Saída", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)==
                DialogResult.Yes)

            {
                Close();

            }
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Numeroum.Text = "";
            Numerodois.Text = "";
            resultado.Text = "";
        }
    }
}
