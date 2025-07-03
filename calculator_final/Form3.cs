using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes; // Importa o namespace necessário para manipulação de JSON
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http; // Importa o namespace necessário para fazer requisições HTTP
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private async void calculate(int opTemp1, int opTemp2, double number)
        {
        }

        private void conversorDeMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            string numberText = inpMoeda1.Text;
            numberText = numberText.Replace(".", ",");

            var culture = new CultureInfo("pt-BR");

            double number = double.Parse(numberText, culture);
            int opTemp1 = slcMoeda1.SelectedIndex;
            int opTemp2 = slcMoeda2.SelectedIndex;

            if (opTemp1 == 0)
            {
                switch (opTemp2)
                {
                    case 1:
                        using (HttpClient client = new HttpClient())
                        {
                            string url = "https://economia.awesomeapi.com.br/json/last/USD-BRL";

                            try
                            {
                                string response = await client.GetStringAsync(url);
                                dynamic resultado = JsonConvert.DeserializeObject(response);
                                decimal cotacao = Convert.ToDecimal(resultado.USDBRL.bid.ToString().Replace(".", ","));

                                decimal valorEmReal = Convert.ToDecimal(inpMoeda1.Text);
                                decimal valorEmDolar = valorEmReal / cotacao;

                                inpMoeda2.Text = valorEmDolar.ToString("F2");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro na conversão: " + ex.Message);
                            }
                        }
                        break;

                    case 2:
                        using (HttpClient client = new HttpClient())
                        {
                            string url = "https://economia.awesomeapi.com.br/json/last/EUR-BRL";

                            try
                            {
                                string response = await client.GetStringAsync(url);
                                dynamic resultado = JsonConvert.DeserializeObject(response);
                                decimal cotacao = Convert.ToDecimal(resultado.EURBRL.bid.ToString().Replace(".", ","));

                                decimal valorEmReal = Convert.ToDecimal(inpMoeda1.Text);
                                decimal valorEmDolar = valorEmReal / cotacao;

                                inpMoeda2.Text = valorEmDolar.ToString("F2");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro na conversão: " + ex.Message);
                            }
                        }
                        break;

                    case 3:
                        using (HttpClient client = new HttpClient())
                        {
                            string url = "https://economia.awesomeapi.com.br/json/last/CAD-BRL";

                            try
                            {
                                string response = await client.GetStringAsync(url);
                                dynamic resultado = JsonConvert.DeserializeObject(response);
                                decimal cotacao = Convert.ToDecimal(resultado.CADBRL.bid.ToString().Replace(".", ","));

                                decimal valorEmReal = Convert.ToDecimal(inpMoeda1.Text);
                                decimal valorEmDolar = valorEmReal / cotacao;

                                inpMoeda2.Text = valorEmDolar.ToString("F2");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro na conversão: " + ex.Message);
                            }
                        }
                        break;
                }
            }
            else if (opTemp1 == 1)
            {
                switch (opTemp2)
                {
                    case 0:
                        using (HttpClient client = new HttpClient())
                        {
                            string url = "https://economia.awesomeapi.com.br/json/last/BRL-USD";

                            try
                            {
                                string response = await client.GetStringAsync(url);
                                dynamic resultado = JsonConvert.DeserializeObject(response);
                                decimal cotacao = Convert.ToDecimal(resultado.BRLUSD.bid.ToString().Replace(".", ","));

                                decimal valorEmReal = Convert.ToDecimal(inpMoeda1.Text);
                                decimal valorEmDolar = valorEmReal / cotacao;

                                inpMoeda2.Text = valorEmDolar.ToString("F2");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro na conversão: " + ex.Message);
                            }
                        }
                        break;

                    case 2:
                        //result = (number - 32) * 5 / 9 + 273.15;
                        //lblFormula.Text = $"({number}ºF -32) x 5 ÷ 9 + 273,15 = {result}K";
                        break;
                    case 3:
                        break;
                }
            }
            else if (opTemp1 == 2)
            {
                switch (opTemp2)
                {
                    case 0:
                        //result = number - 273.15;
                        //lblFormula.Text = $"{number} - 273,15 = {result}ºC";
                        break;

                    case 1:
                        //result = (number - 273.15) * 5 / 9 + 32;
                        //lblFormula.Text = $"({number} - 273,15) x 5 ÷ 9 + 32 = {result}ºF";
                        break;

                    case 3:
                        break;
                }
            }
            else if (opTemp1 == 3)
            {
                switch (opTemp2)
                {
                    case 0:
                        //result = number - 273.15;
                        //lblFormula.Text = $"{number} - 273,15 = {result}ºC";
                        break;

                    case 1:
                        //result = (number - 273.15) * 5 / 9 + 32;
                        //lblFormula.Text = $"({number} - 273,15) x 5 ÷ 9 + 32 = {result}ºF";
                        break;

                    case 2:
                        break;
                }
            }
        }
    }
}
