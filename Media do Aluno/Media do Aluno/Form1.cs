using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtQdeAulas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double Nota1, Nota2, Trabalho;

            Nota1 = Convert.ToDouble(txtNota1.Text) * Convert.ToDouble(CboPesoNota1.Text);
            Nota2 = Double.Parse(txtNota2.Text) * Double.Parse(cbopesoNota2.Text);
            Trabalho = Convert.ToDouble(txtTrabalho.Text) * Convert.ToDouble(cboTrabalho.Text);

            Double Media = Nota1 + Nota2 + Trabalho;

            txtMediaFinal.Text = Media.ToString();


            Double QdeAulas, QdeFaltas;

            QdeAulas = Convert.ToDouble(txtQdeAulas.Text);
            QdeFaltas = Convert.ToDouble(txtQdeFaltas.Text);

            double PorcentagemPresenca = 100 - ((QdeFaltas / QdeAulas) * 100);

            txtAproveitamento.Text = Convert.ToString(((Media * 10) + (PorcentagemPresenca)) /2) + "%";


            if (txtRecuperacao.Text == "")
            {
                if (Media >= Convert.ToDouble(numNotadeCorte.Value) && PorcentagemPresenca >= 75)
                {
                    lblSituacao1.Text = "Aprovado";
                    lblSituacao1.ForeColor = Color.Green;
                }

                else
                    if (Media <= 2.5 || PorcentagemPresenca < 75)
                    {
                        lblSituacao1.Text = "Reprovado";
                        lblSituacao1.ForeColor = Color.Firebrick;
                    }

                    else
                    {
                        lblSituacao1.Text = "Recuperação";
                        lblSituacao1.ForeColor = Color.Firebrick;
                    }
            }
            else
            {
                Media = (Media + Convert.ToDouble(txtRecuperacao.Text)) / 2;

                txtAproveitamento.Text = Convert.ToString(((Media * 10) + (PorcentagemPresenca)) / 2) + "%";

                if (Media >= 5)
                {
                    lblSituacao1.Text = "Aprovado";
                    lblSituacao1.ForeColor = Color.Green;
                }

                else
                {
                    lblSituacao1.Text = "Reprovado";
                    lblSituacao1.ForeColor = Color.Firebrick;
                }

                txtMediaFinal.Text = Media.ToString ();

            }

        }




        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblSituacao1.Text = "";
            lblSituacao1.Text = String.Empty;

            foreach (Control Componente in this.Controls)
            {
                if (Componente is TextBox)
                {
                    (Componente as TextBox).Clear();
                }
                else
                    if (Componente is ComboBox)
                    {
                        (Componente as ComboBox).SelectedIndex = -1;
                    }
                    else
                        if (Componente is NumericUpDown)
                        {
                            (Componente as NumericUpDown).Value = 5;
                        }
            }

        }
    }
}
