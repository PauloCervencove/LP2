using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double verify1, verify2, aliquoINSS, aliquoIRFF, salFamilia, salLiq;



            if (string.IsNullOrWhiteSpace(txtNomeFunc.Text))
                MessageBox.Show("Nome esta em  branco");
            else if (string.IsNullOrWhiteSpace(txtNumFilhos.Text))
                MessageBox.Show("Não foi digitado o  número de filhos");
            else
                if (double.TryParse(txtSalBruto.Text, out verify1) && double.TryParse(txtNumFilhos.Text, out verify2))
            {
                if (rdbtnFem.Checked == true || rdbtnMasculino.Checked == true)
                {
                    string nome;
                    nome = txtNomeFunc.Text;


                    if (rdbtnFem.Checked == true && chkCasado.Checked == true)
                        lblDados.Text = string.Format("Os descontos do salário da Sra.{0}\nque é casada\ne tem {1} filho(s) são:", nome, verify2);
                    if (rdbtnFem.Checked == true && chkCasado.Checked == false)
                        lblDados.Text = string.Format("Os descontos do salário da Sra.{0}\nque é solteira\ne tem {1} filho(s) são:", nome, verify2);
                    if (rdbtnFem.Checked == false && chkCasado.Checked == false)
                        lblDados.Text = string.Format("Os descontos do salário da Sr.{0}\nque é solteiro\ne tem {1} filho(s) são:", nome, verify2);
                    if (rdbtnFem.Checked == false && chkCasado.Checked == true)
                        lblDados.Text = string.Format("Os descontos do salário da Sr.{0}\nque é casado\ne tem {1} filho(s) são:", nome, verify2);



                    //Aliquota INSS
                    if (verify1 <= 800.47)
                    {
                        aliquoINSS = verify1 * (7.65 / 100);
                        txtAliquotaINSS.Text = "7.65%";
                    }
                    else if (verify1 <= 1050)
                    {
                        aliquoINSS = verify1 * (8.65 / 100);
                        txtAliquotaINSS.Text = "8.65 %";
                    }
                    else if (verify1 <= 1400.77)
                    {
                        aliquoINSS = verify1 * (9 / 100);
                        txtAliquotaINSS.Text = "9.00 %";
                    }
                    else if (verify1 <= 2801.56)
                    {
                        aliquoINSS = verify1 * (11 / 100);
                        txtAliquotaINSS.Text = "11 %";
                    }
                    else
                    {
                        aliquoINSS = 308.17;
                        txtAliquotaINSS.Text = "Teto";
                    }

                    txtDescontoINSS.Text = aliquoINSS.ToString("N2");


                    // Aliquota IRFF
                    if (verify1 <= 1257.12)
                    {
                        aliquoIRFF = 0;
                        txtAliquotaIRFF.Text = "0";
                    }
                    else if (verify1 <= 2512.08)
                    {
                        aliquoIRFF = verify1 * (15 / 100);
                        txtAliquotaIRFF.Text = "15%";
                    }
                    else
                    {
                        aliquoIRFF = verify1 * (27.5 / 100);
                        txtAliquotaIRFF.Text = "27.5%";
                    }

                    txtDescontoIRPF.Text = aliquoIRFF.ToString("N2");

                    // Salario familia
                    if (verify1 <= 435.52)
                        salFamilia = verify2 * 22.33;
                    else if (verify1 <= 654.61)
                        salFamilia = verify2 * 15.74;
                    else
                        salFamilia = 0;

                    txtSalFamilia.Text = salFamilia.ToString("N2");

                    // Calculo Salário Liquido

                    salLiq = verify1 - aliquoINSS - aliquoIRFF + salFamilia;

                    txtSalLiquido.Text = salLiq.ToString("N2");




                }

                else
                    MessageBox.Show("Sexo não selecionado");
            }

            else
                MessageBox.Show("Dados Inválidos");
        }
    }
}
