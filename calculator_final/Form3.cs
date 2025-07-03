using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes; // Importa o namespace necessário para manipulação de JSON
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http; // Importa o namespace necessário para fazer requisições HTTP

namespace calculator_final
{
    public partial class FormConversorMoedas : Form
    {
        public FormConversorMoedas()
        {
            InitializeComponent();
        }

        private void inpTemp1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //double number = double.Parse(inpMoeda1.Text);
                //int opTemp1 = slcMoeda1.SelectedIndex;
                //int opTemp2 = slcMoeda2.SelectedIndex;

                //inpMoeda2.Text = calculate(opTemp1, opTemp2, number).ToString("N2");
            }
            catch (Exception ex)
            {
            }
        }

        private async void calculate(string moedaConvert, string moedaConverted)
        {
            if (moedaConvert != moedaConverted)
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://economia.awesomeapi.com.br/json/last/{moedaConverted}-{moedaConvert}";
                    string parammetter = moedaConverted + moedaConvert;

                    try
                    {
                        string response = await client.GetStringAsync(url);
                        dynamic resultado = JsonConvert.DeserializeObject(response);
                        decimal cotacao = Convert.ToDecimal(resultado[parammetter].bid.ToString(), CultureInfo.InvariantCulture);


                        decimal valorEmReal = Convert.ToDecimal(inpMoeda1.Text);
                        decimal valorEmDolar = valorEmReal / cotacao;

                        inpMoeda2.Text = valorEmDolar.ToString("F2");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro na conversão: " + ex.Message);
                    }
                }
            }
        }

        private void conversorDeMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            string moeda1 = slcMoeda1.Text;
            string moeda2 = slcMoeda2.Text;

            calculate(moeda1, moeda2);
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

        private void conversorDeTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConversorTemp formConversorTemp = new FormConversorTemp();
            Hide();
            formConversorTemp.ShowDialog();
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
    }
}
