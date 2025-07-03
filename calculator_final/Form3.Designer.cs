namespace calculator_final
{
    partial class FormConversorMoedas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnsMenu = new MenuStrip();
            calculadoraIMCToolStripMenuItem = new ToolStripMenuItem();
            conversorºCToolStripMenuItem = new ToolStripMenuItem();
            iMCToolStripMenuItem = new ToolStripMenuItem();
            conversorDeMoedasToolStripMenuItem = new ToolStripMenuItem();
            conversorDeTemperaturaToolStripMenuItem = new ToolStripMenuItem();
            regraDeTrêsToolStripMenuItem = new ToolStripMenuItem();
            sAIRToolStripMenuItem = new ToolStripMenuItem();
            inpMoeda2 = new TextBox();
            lblCharEqual = new Label();
            inpMoeda1 = new TextBox();
            slcMoeda2 = new ComboBox();
            slcMoeda1 = new ComboBox();
            lblFormula = new Label();
            lblFormulaText = new Label();
            lblFormula1 = new Label();
            btnCalcular = new Button();
            mnsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mnsMenu
            // 
            mnsMenu.BackColor = Color.Transparent;
            mnsMenu.Items.AddRange(new ToolStripItem[] { calculadoraIMCToolStripMenuItem });
            mnsMenu.Location = new Point(0, 0);
            mnsMenu.Name = "mnsMenu";
            mnsMenu.Size = new Size(800, 24);
            mnsMenu.TabIndex = 26;
            mnsMenu.Text = "menuStrip1";
            // 
            // calculadoraIMCToolStripMenuItem
            // 
            calculadoraIMCToolStripMenuItem.BackColor = Color.FromArgb(76, 74, 76);
            calculadoraIMCToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conversorºCToolStripMenuItem, iMCToolStripMenuItem, conversorDeMoedasToolStripMenuItem, conversorDeTemperaturaToolStripMenuItem, regraDeTrêsToolStripMenuItem, sAIRToolStripMenuItem });
            calculadoraIMCToolStripMenuItem.Name = "calculadoraIMCToolStripMenuItem";
            calculadoraIMCToolStripMenuItem.Size = new Size(50, 20);
            calculadoraIMCToolStripMenuItem.Text = "Menu";
            // 
            // conversorºCToolStripMenuItem
            // 
            conversorºCToolStripMenuItem.BackColor = Color.FromArgb(76, 74, 76);
            conversorºCToolStripMenuItem.ForeColor = Color.White;
            conversorºCToolStripMenuItem.Name = "conversorºCToolStripMenuItem";
            conversorºCToolStripMenuItem.Size = new Size(212, 22);
            conversorºCToolStripMenuItem.Text = "Calculadora";
            // 
            // iMCToolStripMenuItem
            // 
            iMCToolStripMenuItem.BackColor = Color.FromArgb(76, 74, 76);
            iMCToolStripMenuItem.ForeColor = Color.White;
            iMCToolStripMenuItem.Name = "iMCToolStripMenuItem";
            iMCToolStripMenuItem.Size = new Size(212, 22);
            iMCToolStripMenuItem.Text = "IMC";
            // 
            // conversorDeMoedasToolStripMenuItem
            // 
            conversorDeMoedasToolStripMenuItem.BackColor = Color.FromArgb(76, 74, 76);
            conversorDeMoedasToolStripMenuItem.ForeColor = Color.White;
            conversorDeMoedasToolStripMenuItem.Name = "conversorDeMoedasToolStripMenuItem";
            conversorDeMoedasToolStripMenuItem.Size = new Size(212, 22);
            conversorDeMoedasToolStripMenuItem.Text = "Conversor de moedas";
            conversorDeMoedasToolStripMenuItem.Click += conversorDeMoedasToolStripMenuItem_Click;
            // 
            // conversorDeTemperaturaToolStripMenuItem
            // 
            conversorDeTemperaturaToolStripMenuItem.BackColor = Color.FromArgb(76, 74, 76);
            conversorDeTemperaturaToolStripMenuItem.ForeColor = Color.White;
            conversorDeTemperaturaToolStripMenuItem.Name = "conversorDeTemperaturaToolStripMenuItem";
            conversorDeTemperaturaToolStripMenuItem.Size = new Size(212, 22);
            conversorDeTemperaturaToolStripMenuItem.Text = "Conversor de temperatura";
            // 
            // regraDeTrêsToolStripMenuItem
            // 
            regraDeTrêsToolStripMenuItem.BackColor = Color.FromArgb(76, 74, 76);
            regraDeTrêsToolStripMenuItem.ForeColor = Color.White;
            regraDeTrêsToolStripMenuItem.Name = "regraDeTrêsToolStripMenuItem";
            regraDeTrêsToolStripMenuItem.Size = new Size(212, 22);
            regraDeTrêsToolStripMenuItem.Text = "Regra de três";
            // 
            // sAIRToolStripMenuItem
            // 
            sAIRToolStripMenuItem.BackColor = Color.FromArgb(228, 103, 83);
            sAIRToolStripMenuItem.ForeColor = Color.White;
            sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            sAIRToolStripMenuItem.Size = new Size(212, 22);
            sAIRToolStripMenuItem.Text = "Sair";
            // 
            // inpMoeda2
            // 
            inpMoeda2.BackColor = Color.FromArgb(51, 51, 51);
            inpMoeda2.BorderStyle = BorderStyle.FixedSingle;
            inpMoeda2.Font = new Font("Segoe UI", 16F);
            inpMoeda2.ForeColor = Color.White;
            inpMoeda2.Location = new Point(437, 161);
            inpMoeda2.Name = "inpMoeda2";
            inpMoeda2.ReadOnly = true;
            inpMoeda2.Size = new Size(180, 36);
            inpMoeda2.TabIndex = 35;
            // 
            // lblCharEqual
            // 
            lblCharEqual.AutoSize = true;
            lblCharEqual.Font = new Font("Segoe UI", 20F);
            lblCharEqual.Location = new Point(384, 175);
            lblCharEqual.Name = "lblCharEqual";
            lblCharEqual.Size = new Size(35, 37);
            lblCharEqual.TabIndex = 34;
            lblCharEqual.Text = "=";
            // 
            // inpMoeda1
            // 
            inpMoeda1.BackColor = Color.FromArgb(51, 51, 51);
            inpMoeda1.BorderStyle = BorderStyle.FixedSingle;
            inpMoeda1.Font = new Font("Segoe UI", 16F);
            inpMoeda1.ForeColor = Color.White;
            inpMoeda1.Location = new Point(184, 161);
            inpMoeda1.Name = "inpMoeda1";
            inpMoeda1.Size = new Size(180, 36);
            inpMoeda1.TabIndex = 33;
            inpMoeda1.TextChanged += inpTemp1_TextChanged;
            // 
            // slcMoeda2
            // 
            slcMoeda2.DropDownStyle = ComboBoxStyle.DropDownList;
            slcMoeda2.Font = new Font("Segoe UI", 16F);
            slcMoeda2.FormattingEnabled = true;
            slcMoeda2.Items.AddRange(new object[] { "Real", "Dólar americano", "Euro", "Dólar Canadense", "Pesos" });
            slcMoeda2.Location = new Point(437, 194);
            slcMoeda2.Name = "slcMoeda2";
            slcMoeda2.Size = new Size(180, 38);
            slcMoeda2.TabIndex = 32;
            // 
            // slcMoeda1
            // 
            slcMoeda1.DropDownStyle = ComboBoxStyle.DropDownList;
            slcMoeda1.Font = new Font("Segoe UI", 16F);
            slcMoeda1.FormattingEnabled = true;
            slcMoeda1.Items.AddRange(new object[] { "Real", "Dólar americano", "Euro", "Dólar Canadense" });
            slcMoeda1.Location = new Point(184, 194);
            slcMoeda1.Name = "slcMoeda1";
            slcMoeda1.Size = new Size(180, 38);
            slcMoeda1.TabIndex = 31;
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.Font = new Font("Segoe UI", 16F);
            lblFormula.ForeColor = Color.White;
            lblFormula.Location = new Point(293, 260);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(0, 30);
            lblFormula.TabIndex = 37;
            // 
            // lblFormulaText
            // 
            lblFormulaText.AutoSize = true;
            lblFormulaText.BackColor = Color.FromArgb(244, 191, 0);
            lblFormulaText.Font = new Font("Segoe UI", 16F);
            lblFormulaText.ForeColor = Color.FromArgb(36, 26, 0);
            lblFormulaText.Location = new Point(184, 260);
            lblFormulaText.Name = "lblFormulaText";
            lblFormulaText.Size = new Size(92, 30);
            lblFormulaText.TabIndex = 36;
            lblFormulaText.Text = "Fórmula";
            // 
            // lblFormula1
            // 
            lblFormula1.AutoSize = true;
            lblFormula1.Font = new Font("Segoe UI", 16F);
            lblFormula1.ForeColor = Color.White;
            lblFormula1.Location = new Point(293, 305);
            lblFormula1.Name = "lblFormula1";
            lblFormula1.Size = new Size(0, 30);
            lblFormula1.TabIndex = 38;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 14F);
            btnCalcular.Location = new Point(437, 251);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(180, 39);
            btnCalcular.TabIndex = 39;
            btnCalcular.Text = "Cotar";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormConversorMoedas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblFormula1);
            Controls.Add(lblFormula);
            Controls.Add(lblFormulaText);
            Controls.Add(inpMoeda2);
            Controls.Add(lblCharEqual);
            Controls.Add(inpMoeda1);
            Controls.Add(slcMoeda2);
            Controls.Add(slcMoeda1);
            Controls.Add(mnsMenu);
            Name = "FormConversorMoedas";
            Text = "Conversor de Moedas";
            mnsMenu.ResumeLayout(false);
            mnsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsMenu;
        private ToolStripMenuItem calculadoraIMCToolStripMenuItem;
        private ToolStripMenuItem conversorºCToolStripMenuItem;
        private ToolStripMenuItem iMCToolStripMenuItem;
        private ToolStripMenuItem conversorDeMoedasToolStripMenuItem;
        private ToolStripMenuItem conversorDeTemperaturaToolStripMenuItem;
        private ToolStripMenuItem regraDeTrêsToolStripMenuItem;
        private ToolStripMenuItem sAIRToolStripMenuItem;
        private TextBox inpMoeda2;
        private Label lblCharEqual;
        private TextBox inpMoeda1;
        private ComboBox slcMoeda2;
        private ComboBox slcMoeda1;
        private Label lblFormula;
        private Label lblFormulaText;
        private Label lblFormula1;
        private Button btnCalcular;
    }
}