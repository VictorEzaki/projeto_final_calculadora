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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float peso, altura, result;

            peso = float.Parse(inpPeso.Text);
            altura = float.Parse(inpAltura.Text);

            result = peso / (altura * altura);

            lblResult.Text = result.ToString("N2");

        }
    }
}
