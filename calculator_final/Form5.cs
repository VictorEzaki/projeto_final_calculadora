using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_final
{
    public partial class FormRegraTres : Form
    {
        public FormRegraTres()
        {
            InitializeComponent();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;

            if (inpNum1.Text != "" && inpNum2.Text != "" && inpNum3.Text != "")
            {
                num1 = double.Parse(inpNum1.Text);
                num2 = double.Parse(inpNum2.Text);
                num3 = double.Parse(inpNum3.Text);

                lblResult.Text = (num2 * num3 / num1).ToString("N2");
            }
        }

        private void inpNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // bloqueia qualquer outro caractere
            }
        }

        private void inpNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // bloqueia qualquer outro caractere
            }
        }

        private void inpNum3_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpNum3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // bloqueia qualquer outro caractere
            }
        }

        private void conversorºCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
            form1.ShowDialog();
        }

        private void iMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIMC formIMC = new FormIMC();
            Hide();
            formIMC.ShowDialog();
        }

        private void conversorDeMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConversorMoedas formConversorMoedas = new FormConversorMoedas();
            Hide();
            formConversorMoedas.ShowDialog();
        }

        private void conversorDeTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConversorTemp formConversorTemp = new FormConversorTemp();
            Hide();
            formConversorTemp.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
