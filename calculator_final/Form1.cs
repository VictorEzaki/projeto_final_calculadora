using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace calculator_final
{
    public partial class Form1 : Form
    {
        List<string> history = new List<string>();

        private string StringResult { get; set; }

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
            FormIMC formIMC = new FormIMC();
            Hide();
            formIMC.ShowDialog();
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
            try
            {
                float num = float.Parse(lblResult.Text);

                num *= -1;

                lblResult.Text = num.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            StringResult = "";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            try
            {
                string number = lblResult.Text;

                lblResult.Text = number.Remove(number.Length - 1, 1);
            }
            catch (Exception ex) { }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                StringResult += lblResult.Text;
                string expression = StringResult;

                expression = expression.Replace("x", "*").Replace("÷", "/").Replace(",", ".");

                var result = new DataTable().Compute(expression, null);

                lblResult.Text = result.ToString();
                history.Add(StringResult + " = " + lblResult.Text);
                StringResult = "";
                lblAuxiliar.Text = "";
            }
            catch (Exception error)
            {

            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblResult.Text += "+";
            StringResult += lblResult.Text;
            lblAuxiliar.Text += lblResult.Text;
            lblResult.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblResult.Text += "-";
            StringResult += lblResult.Text;
            lblAuxiliar.Text += lblResult.Text;
            lblResult.Text = "";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblResult.Text += "x";
            StringResult += lblResult.Text;
            lblAuxiliar.Text += lblResult.Text;
            lblResult.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblResult.Text += "÷";
            StringResult += lblResult.Text;
            lblAuxiliar.Text += lblResult.Text;
            lblResult.Text = "";
        }

        private void btnPorcent_Click(object sender, EventArgs e)
        {
            try
            {
                float num = float.Parse(lblResult.Text);
                num /= 100;
                StringResult += num.ToString();
                lblAuxiliar.Text += num.ToString();
                lblResult.Text = "";
                lblResult.Text = "";
            }
            catch (Exception ex)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void regraDeTrêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegraTres formRegraTres = new FormRegraTres();
            Hide();
            formRegraTres.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // percorre toda a lista para fazer histórico
            string message = "";
            foreach (string item in history)
            {
                message += item + "\n";
            }

            MessageBox.Show(message);
        }

        private void FormCalculadora_Click(object sender, EventArgs e)
        {

        }
    }
}
