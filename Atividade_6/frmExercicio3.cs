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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 50)
            {
                textBox1.Text = textBox1.Text.ToUpper();
                textBox1.Text = textBox1.Text.Replace(" ", "");
                string s = textBox1.Text;
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                s = "";
                foreach (char c in arr)
                    s = s + c.ToString();
                if (s == textBox1.Text)
                {
                    MessageBox.Show("É palíndromo!");
                }
                else
                {
                    MessageBox.Show("Não é palíndromo!");
                }
            }
        }
    }
}
