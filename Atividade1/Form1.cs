using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalcRaio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtRaio.Text = "";
            txtVolume.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio, altura;
            if ((double.TryParse(txtAltura.Text, out raio)) && double.TryParse(txtRaio.Text, out altura))
            {
                if ((raio < 0) || (altura < 0))
                {
                    MessageBox.Show("Não pode digitar numero negativo");
                }
                else
                {
                    double Volume = Math.PI * Math.Pow(raio, 2) * altura;
                    txtVolume.Text = Volume.ToString("N2");
                }
            }
        }
    }
}
