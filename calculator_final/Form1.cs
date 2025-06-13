namespace calculator_final
{
    public partial class Form1 : Form
    {
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
    }
}
