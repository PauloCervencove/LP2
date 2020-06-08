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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            int x = 0;
            string auxiliar = "";
            string valor = "";
            for (x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o dado " + (x + 1), "Entrada de dados");
                if (int.TryParse(valor, out vetor[x]))
                {
                    //auxiliar = auxiliar + "\n" + vetor[x].ToString();
                    auxiliar = vetor[x].ToString() + "\n" + auxiliar;
                }
                else
                {
                    MessageBox.Show("Dado Inválido!");
                    x--;
                }

            }
            MessageBox.Show(auxiliar);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            int x = 0;
            string auxiliar = "";
            string valor = "";
            for (x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o dado " + (x + 1), "Entrada de dados");
                if (!int.TryParse(valor, out vetor[x]))
                {
                    MessageBox.Show("Dado Inválido!");
                    x--;
                }

            }
            Array.Reverse(vetor);
            for (x = 0; x < 20; x++)
                auxiliar += vetor[x] + "\n";
            MessageBox.Show(auxiliar);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double[] mercadorias = new double[10];
            double[] precos = new double[10];
            int x, y;
            string valor = "";
            double faturamento = 0;
            for (x = 0; x < 10; x++)
            {
                y = 0;
                while (y == 0)
                {
                    valor = Interaction.InputBox("Digite a quantidade da mercadoria " + (x + 1), "Entrada de dados");
                    if (!double.TryParse(valor, out mercadorias[x]))
                    {
                        MessageBox.Show("Dado Inválido!");
                    }
                    else
                    {
                        y = 1;
                    }
                }
                y = 0;
                while (y == 0)
                {
                    valor = Interaction.InputBox("Digite o valor da mercadoria " + (x + 1), "Entrada de dados");
                    if (!double.TryParse(valor, out precos[x]))
                    {
                        MessageBox.Show("Dado Inválido!");
                    }
                    else
                    {
                        y = 1;
                    }
                }
                faturamento += precos[x] * mercadorias[x];

            }
            MessageBox.Show("Faturamento mensal: " + faturamento + " reais");

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ArrayList nomes = new ArrayList();
            nomes.Add("Ana");
            nomes.Add("André");
            nomes.Add("Débora");
            nomes.Add("Fátima");
            nomes.Add("João");
            nomes.Add("Janete");
            nomes.Add("Otávio");
            nomes.Add("Marcelo");
            nomes.Add("Pedro");
            nomes.Add("Thais");
            nomes.Remove("Otávio");
            foreach (string item in nomes)
            {
                MessageBox.Show(item);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
                Total += Alunos[I].Length;
            MessageBox.Show("Resposta:" + Total);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            double[,] alunos = new double[20, 3];
            int i, j;
            string nota = "";
            double media;
            for (i = 0; i < 20; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    nota = Interaction.InputBox("Digite a nota " + (j + 1) + " do aluno " + (i + 1), "Entrada de dados");
                    if (!double.TryParse(nota, out alunos[i, j]))
                    {
                        MessageBox.Show("Nota Inválida");
                        j--;
                    }
                }
            }
            for (i = 0; i < 20; i++)
            {
                media = ((alunos[i, 0] + alunos[i, 1] + alunos[i, 2]) / 3);
                MessageBox.Show("A média do aluno " + (i + 1) + " é " + media);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Form f = new Exercicio_7();
            f.Closed += (s, args) => this.Close();
            this.Hide();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
