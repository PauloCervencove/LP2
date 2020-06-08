using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double a, b, c, x;
            if (double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b) && double.TryParse(txtC.Text, out c) & a > 0 & b > 0 & c > 0)
            {
                if (b > a && b > c)
                {
                    x = a;
                    a = b;
                    b = x;
                }
                if (c > b && c > a)
                {
                    x = a;
                    a = c;
                    c = x;
                }

                if (a >= b + c)
                    MessageBox.Show("Não forma triângulo");
                else if (a == b && b == c)
                    MessageBox.Show("Triângulo Equilátero");
                else if (a != b && b != c)
                    MessageBox.Show("Triângulo Escaleno");
                else if (a == b || b == c || c == a)
                    MessageBox.Show("Triângulo Isósceles");
            }
            else
                MessageBox.Show("Dados Invalidos");
        }
    }
}
