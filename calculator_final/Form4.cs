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
    public partial class FormConversorTemp : Form
    {
        public FormConversorTemp()
        {
            InitializeComponent();
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

        private void regraDeTrêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegraTres formRegraTres = new FormRegraTres();
            Hide();
            formRegraTres.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private double calculate(int slcTempWrite, int convertSelected, double number)
        {
            double result = 0;

            if (slcTempWrite == 0)
            {
                switch (convertSelected)
                {
                    case 1:
                        result = (number * 9 / 5) + 32;
                        lblFormula.Text = $"({number}ºC x 9 ÷ 5) + 32 = {result}ºF";
                        break;

                    case 2:
                        result = number + 273.15;
                        lblFormula.Text = $"{number}ºC + 273.15 = {result}K";
                        break;
                }
            }
            else if (slcTempWrite == 1)
            {
                switch (convertSelected)
                {
                    case 0:
                        result = (number - 32) * 5 / 9;
                        lblFormula.Text = $"({number}ºF - 32) x 5 ÷ 9 = {result}ºC";
                        break;

                    case 2:
                        result = (number - 32) * 5 / 9 + 273.15;
                        lblFormula.Text = $"({number}ºF -32) x 5 ÷ 9 + 273,15 = {result}K";
                        break;
                }
            }
            else if (slcTempWrite == 2)
            {
                switch (convertSelected)
                {
                    case 0:
                        result = number - 273.15;
                        lblFormula.Text = $"{number} - 273,15 = {result}ºC";
                        break;

                    case 1:
                        result = (number - 273.15) * 5 / 9 + 32;
                        lblFormula.Text = $"({number} - 273,15) x 5 ÷ 9 + 32 = {result}ºF";
                        break;
                }
            }

            return result;
        }

        private void inpTemp1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(inpTemp1.Text);
                int opTemp1 = slcTemp1.SelectedIndex;
                int opTemp2 = slcTemp2.SelectedIndex;

                inpTemp2.Text = calculate(opTemp1, opTemp2, number).ToString("N2");
            }
            catch (Exception ex)
            {
            }
        }
    }
}
