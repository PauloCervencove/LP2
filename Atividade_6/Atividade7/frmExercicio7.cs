using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int i;
            ArrayList nomes = new ArrayList();
            string nome = "";
            int count;
            int x = 0;
            for (i = 0; i < 2; i++)
            {
                nome = Interaction.InputBox("Digite o nome da " + (i + 1) + " pessoa", "Entrada de dados");
                nomes.Add(nome);

            }
            foreach (string item in nomes)
            {

                count = item.Length;
                while (x < item.Length)
                {
                    if (Char.IsWhiteSpace(item[x]))
                    {
                        count -= 1;
                    }
                    x++;
                }
                listBox1.Items.Add("O nome: " + item + " tem " + count + " caracteres");
            }

        }
    }
}
