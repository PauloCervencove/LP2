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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {

            int x = 0, y = 0;

            while (x < rchtxtTexto.Text.Length)
            {
                if (Char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    y += 1;
                }
                x += 1;
            }
            MessageBox.Show("Espaços em brancos existentes:" + y);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            string frase = rchtxtTexto.Text.Trim();
            int x = 0;
            foreach (char letra in frase)
            {
                if (letra == 'R' || letra == 'r')
                {
                    x += 1;
                }
            }
            MessageBox.Show("Tem um total de: " + x + " R's");
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            string letra = "";
            for (x = 0; x < rchtxtTexto.Text.Length; x++)
            {
                if (rchtxtTexto.Text.Substring(x, 1) == letra)
                {
                    y++;
                }

                letra = rchtxtTexto.Text.Substring(x, 1);
            }

            MessageBox.Show("O numero de pares é:" + y);
        }
    }
    
}
