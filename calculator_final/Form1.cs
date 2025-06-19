using System.Data;
using System.Linq.Expressions;

namespace calculator_final
{
    public partial class Form1 : Form
    {
        List<float> history = new List<float>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            lblResult.Text += 4;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void conversorºCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            lblResult.Text += 1;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            lblResult.Text += 2;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            lblResult.Text += 0;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lblResult.Text += 3;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lblResult.Text += 5;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lblResult.Text += 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            lblResult.Text += 7;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            lblResult.Text += 8;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            lblResult.Text += 9;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            lblResult.Text += ",";
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            float num = float.Parse(lblResult.Text);

            num *= -1;

            lblResult.Text = num.ToString();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string expression = lblResult.Text;

            expression = expression.Replace("x", "*").Replace("÷", "/");

            var regex = new System.Text.RegularExpressions.Regex(@"(\d+(?:\.\d+)?)([+\-*/])(\d+(?:\.\d+)?)%");
            expression = regex.Replace(expression, match =>
            {
                string valorAnterior = match.Groups[1].Value;
                string operador = match.Groups[2].Value;
                string percentual = match.Groups[3].Value;

                return $"{valorAnterior}{operador}({percentual}/100*{valorAnterior})";
            });

            var result = new DataTable().Compute(expression, null);

            lblResult.Text = result.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblResult.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblResult.Text += "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblResult.Text += "x";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblResult.Text += "÷";
        }

        private void btnPorcent_Click(object sender, EventArgs e)
        {
            lblResult.Text += "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
