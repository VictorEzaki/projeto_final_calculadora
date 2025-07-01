using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_final
{
    public partial class FormIMC : Form
    {
        public FormIMC()
        {
            InitializeComponent();
            inpAltura.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calculateIMC();
        }

        private void calculateIMC()
        {
            try
            {
                float peso, altura, result = 0;
                string pesoFormat;

                var culture = new CultureInfo("pt-BR");

                pesoFormat = inpPeso.Text;
                pesoFormat = pesoFormat.Replace(",", ".");
                peso = float.Parse(pesoFormat, culture);
                altura = float.Parse(inpAltura.Text, culture);

                if (peso <= 0 || altura <= 0)
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    result = peso / (altura * altura);

                    if (result >= 60)
                    {
                        lblResult.ForeColor = Color.Red;
                        lblResult.Text = result.ToString("N2") + " Você está com obesidade grau V!";
                        lblResult.Left = (this.ClientSize.Width - lblResult.Width) / 2;
                    }
                    else if (result >= 50)
                    {
                        lblResult.ForeColor = Color.Red;
                        lblResult.Text = result.ToString("N2") + " Você está com obesidade grau IV!";
                        lblResult.Left = (this.ClientSize.Width - lblResult.Width) / 2;
                    }
                    else if (result >= 40)
                    {
                        lblResult.ForeColor = Color.Red;
                        lblResult.Text = result.ToString("N2") + " Você está com obesidade grau III!";
                        lblResult.Left = (this.ClientSize.Width - lblResult.Width) / 2;
                    }
                    else if (result >= 35)
                    {
                        lblResult.ForeColor = Color.Red;
                        lblResult.Text = result.ToString("N2") + " Você está com obesidade grau II!";
                        lblResult.Left = (this.ClientSize.Width - lblResult.Width) / 2;
                    }
                    else if (result >= 30)
                    {
                        lblResult.ForeColor = Color.Red;
                        lblResult.Text = result.ToString("N2") + " Você está com obesidade grau I!";
                        lblResult.Left = (this.ClientSize.Width - lblResult.Width) / 2;
                    }
                    else if (result >= 25)
                    {
                        lblResult.ForeColor = Color.LightGoldenrodYellow;
                        lblResult.Text = result.ToString("N2") + " Você está com SobrePeso!";
                        lblResult.Left = (this.ClientSize.Width - lblResult.Width) / 2;
                    }
                    else if (result >= 18.5)
                    {
                        lblResult.ForeColor = Color.Green;
                        lblResult.Text = result.ToString("N2") + " Seu peso está normal!!";
                        lblResult.Left = (this.ClientSize.Width - lblResult.Width) / 2;
                    }
                    else if (result <= 18.5)
                    {
                        lblResult.ForeColor = Color.LightGoldenrodYellow;
                        lblResult.Text = result.ToString("N2") + " Você está abaixo do peso!";
                        lblResult.Left = (this.ClientSize.Width - lblResult.Width) / 2;
                    }
                }
            }
            catch (Exception error)
            {
                inpPeso.Text = "";
                MessageBox.Show("O peso precisa ter valores numéricos");
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            inpPeso.Text = "";
            inpAltura.Text = "";
        }

        private void btnCalcular_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void inpAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnCalcular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                calculateIMC();
            }
        }

        private void inpAltura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                calculateIMC();
            }
        }

        private void inpPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                calculateIMC();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void conversorºCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
            form1.ShowDialog();
        }
    }
}
