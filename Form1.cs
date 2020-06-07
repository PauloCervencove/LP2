using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double verify1, verify2, pesoIdeal;
            if (double.TryParse(txtAltura.Text, out verify1) && double.TryParse(txtPeso.Text, out verify2))
            {
                if (rdbtnFem.Checked == true || rdbtnMasc.Checked == true)
                {

                    if (rdbtnFem.Checked == true)
                        pesoIdeal = ((62.1 * verify1) - 44.7);



                    if (verify2 == pesoIdeal)
                    {
                        MessageBox.Show("Você está com o peso ideal!");
                    }
                    else if (verify2 < pesoIdeal)
                        MessageBox.Show("Coma bastante massas e doces!");
                    else  (verify2 > pesoIdeal)
                        MessageBox.Show("Regime obrigatório já!");
                    
                }
                else if (rdbtnMasc.Checked == true)
                {
                    
                        
                    
                        pesoIdeal = ((72.7 * verify1) - 58);

                    if (verify2 == pesoIdeal)
                        MessageBox.Show("Você está com o peso ideal!");
                    else if (verify2 < pesoIdeal)
                        MessageBox.Show("Coma bastante massas e doces!");
                    else if (verify2 > pesoIdeal)
                        MessageBox.Show("Regime obrigatório já!");
                }
                else
                    MessageBox.Show("Sexo não selecionado");
            }
            else
                MessageBox.Show("Dados Inválidos!");

        }
    }
}
