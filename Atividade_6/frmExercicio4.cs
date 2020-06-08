using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double prod, b = 0, c = 0, d = 0;
            if (Double.TryParse(txtProd.Text, out prod))
            {
                if (prod >= 100)
                {
                    b = 1;
                }
                if (prod >= 120)
                {
                    c = 1;
                }
                if (prod >= 150)
                {
                    d = 1;
                }
            }
            else MessageBox.Show("Dados de produção inválidos!");
            double sal, salBruto = 0;
            if (Double.TryParse(txtSal.Text, out sal))
            {
                salBruto = sal + sal * (0.05 * b + 0.1 * c + d * 0.1);
            }
            else MessageBox.Show("Salário inválido!");
            double grat;
            if (Double.TryParse(txtGrat.Text, out grat))
            {
                salBruto += grat;

            }
            else MessageBox.Show("Gratificação Inválida!");

            if (salBruto > 7000)
            {
                if (prod < 150)
                {
                    salBruto = 7000 + grat;
                }
            }
            txtSalBruto.Text = salBruto.ToString();

        }
    }
}
