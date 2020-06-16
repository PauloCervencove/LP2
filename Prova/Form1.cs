using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P0030481921006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[] totalMeses = new double[6];
            double[,] matriz = new double[6, 4];
            double totalGeral = 0.0;
            string resultado = ""; 
            int i, j;

            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (!Double.TryParse(Interaction.InputBox("Total vendido (Mes " + (i + 1) + ", Semana " + (j + 1) + "):"), out matriz[i, j]))
                    {
                        MessageBox.Show("Valor é inválido.");
                        j--;
                    }
                    else
                    {
                        totalMeses[i] += matriz[i, j];
                        resultado += "Total do mês: " + (i + 1) + " Semana: " + (j + 1) + " R$" + matriz[i, j].ToString("N2") + "\n";
                        lstVendas.Items.Add(resultado);
                        resultado = "";
                    }
                }
                resultado += ">>> Total Mês: " + totalMeses[i].ToString("N2") + "\n";
                lstVendas.Items.Add(resultado);
                resultado = "-----------------------------------";
                lstVendas.Items.Add(resultado);
                resultado = "";
            }

            foreach (double d in totalMeses)
                totalGeral += d;
            resultado += ">> Total geral:" + totalGeral.ToString("N2");

            lstVendas.Items.Add(resultado);


        }
    }
}
