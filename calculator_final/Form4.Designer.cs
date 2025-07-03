namespace calculator_final
{
    partial class FormConversorTemp
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
            slcTemp1 = new ComboBox();
            slcTemp2 = new ComboBox();
            inpTemp1 = new TextBox();
            mnsMenu = new MenuStrip();
            calculadoraIMCToolStripMenuItem = new ToolStripMenuItem();
            conversorºCToolStripMenuItem = new ToolStripMenuItem();
            iMCToolStripMenuItem = new ToolStripMenuItem();
            conversorDeMoedasToolStripMenuItem = new ToolStripMenuItem();
            conversorDeTemperaturaToolStripMenuItem = new ToolStripMenuItem();
            regraDeTrêsToolStripMenuItem = new ToolStripMenuItem();
            sAIRToolStripMenuItem = new ToolStripMenuItem();
            lblCharEqual = new Label();
            lblFormulaText = new Label();
            lblFormula = new Label();
            inpTemp2 = new TextBox();
            lblFormula2 = new Label();
            mnsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // slcTemp1
            // 
            slcTemp1.DropDownStyle = ComboBoxStyle.DropDownList;
            slcTemp1.Font = new Font("Segoe UI", 16F);
            slcTemp1.FormattingEnabled = true;
            slcTemp1.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin" });
            slcTemp1.Location = new Point(184, 190);
            slcTemp1.Name = "slcTemp1";
            slcTemp1.Size = new Size(180, 38);
            slcTemp1.TabIndex = 22;
            slcTemp1.SelectedIndexChanged += slcTemp1_SelectedIndexChanged;
            // 
            // slcTemp2
            // 
            slcTemp2.DropDownStyle = ComboBoxStyle.DropDownList;
            slcTemp2.Font = new Font("Segoe UI", 16F);
            slcTemp2.FormattingEnabled = true;
            slcTemp2.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin" });
            slcTemp2.Location = new Point(437, 190);
            slcTemp2.Name = "slcTemp2";
            slcTemp2.Size = new Size(180, 38);
            slcTemp2.TabIndex = 23;
            // 
            // inpTemp1
            // 
            inpTemp1.BackColor = Color.FromArgb(51, 51, 51);
            inpTemp1.BorderStyle = BorderStyle.FixedSingle;
            inpTemp1.Font = new Font("Segoe UI", 16F);
            inpTemp1.ForeColor = Color.White;
            inpTemp1.Location = new Point(184, 157);
            inpTemp1.Name = "inpTemp1";
            inpTemp1.Size = new Size(180, 36);
            inpTemp1.TabIndex = 24;
            inpTemp1.TextChanged += inpTemp1_TextChanged;
            // 
            // mnsMenu
            // 
            mnsMenu.BackColor = Color.Transparent;
            mnsMenu.Items.AddRange(new ToolStripItem[] { calculadoraIMCToolStripMenuItem });
            mnsMenu.Location = new Point(0, 0);
            mnsMenu.Name = "mnsMenu";
            mnsMenu.Size = new Size(800, 24);
            mnsMenu.TabIndex = 25;
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
            conversorºCToolStripMenuItem.Click += conversorºCToolStripMenuItem_Click;
            // 
            // iMCToolStripMenuItem
            // 
            iMCToolStripMenuItem.BackColor = Color.FromArgb(76, 74, 76);
            iMCToolStripMenuItem.ForeColor = Color.White;
            iMCToolStripMenuItem.Name = "iMCToolStripMenuItem";
            iMCToolStripMenuItem.Size = new Size(212, 22);
            iMCToolStripMenuItem.Text = "IMC";
            iMCToolStripMenuItem.Click += iMCToolStripMenuItem_Click;
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
            regraDeTrêsToolStripMenuItem.Click += regraDeTrêsToolStripMenuItem_Click;
            // 
            // sAIRToolStripMenuItem
            // 
            sAIRToolStripMenuItem.BackColor = Color.FromArgb(228, 103, 83);
            sAIRToolStripMenuItem.ForeColor = Color.White;
            sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            sAIRToolStripMenuItem.Size = new Size(212, 22);
            sAIRToolStripMenuItem.Text = "Sair";
            sAIRToolStripMenuItem.Click += sAIRToolStripMenuItem_Click;
            // 
            // lblCharEqual
            // 
            lblCharEqual.AutoSize = true;
            lblCharEqual.Font = new Font("Segoe UI", 20F);
            lblCharEqual.Location = new Point(384, 171);
            lblCharEqual.Name = "lblCharEqual";
            lblCharEqual.Size = new Size(35, 37);
            lblCharEqual.TabIndex = 27;
            lblCharEqual.Text = "=";
            // 
            // lblFormulaText
            // 
            lblFormulaText.AutoSize = true;
            lblFormulaText.BackColor = Color.FromArgb(244, 191, 0);
            lblFormulaText.Font = new Font("Segoe UI", 16F);
            lblFormulaText.ForeColor = Color.FromArgb(36, 26, 0);
            lblFormulaText.Location = new Point(184, 263);
            lblFormulaText.Name = "lblFormulaText";
            lblFormulaText.Size = new Size(92, 30);
            lblFormulaText.TabIndex = 28;
            lblFormulaText.Text = "Fórmula";
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.Font = new Font("Segoe UI", 16F);
            lblFormula.ForeColor = Color.White;
            lblFormula.Location = new Point(293, 263);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(0, 30);
            lblFormula.TabIndex = 29;
            // 
            // inpTemp2
            // 
            inpTemp2.BackColor = Color.FromArgb(51, 51, 51);
            inpTemp2.BorderStyle = BorderStyle.FixedSingle;
            inpTemp2.Font = new Font("Segoe UI", 16F);
            inpTemp2.ForeColor = Color.White;
            inpTemp2.Location = new Point(437, 157);
            inpTemp2.Name = "inpTemp2";
            inpTemp2.ReadOnly = true;
            inpTemp2.Size = new Size(180, 36);
            inpTemp2.TabIndex = 30;
            // 
            // lblFormula2
            // 
            lblFormula2.AutoSize = true;
            lblFormula2.Font = new Font("Segoe UI", 16F);
            lblFormula2.ForeColor = Color.White;
            lblFormula2.Location = new Point(293, 307);
            lblFormula2.Name = "lblFormula2";
            lblFormula2.Size = new Size(0, 30);
            lblFormula2.TabIndex = 31;
            // 
            // FormConversorTemp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblFormula2);
            Controls.Add(inpTemp2);
            Controls.Add(lblFormula);
            Controls.Add(lblFormulaText);
            Controls.Add(lblCharEqual);
            Controls.Add(mnsMenu);
            Controls.Add(inpTemp1);
            Controls.Add(slcTemp2);
            Controls.Add(slcTemp1);
            Name = "FormConversorTemp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            mnsMenu.ResumeLayout(false);
            mnsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox slcTemp1;
        private ComboBox slcTemp2;
        private TextBox inpTemp1;
        private MenuStrip mnsMenu;
        private ToolStripMenuItem calculadoraIMCToolStripMenuItem;
        private ToolStripMenuItem conversorºCToolStripMenuItem;
        private ToolStripMenuItem iMCToolStripMenuItem;
        private ToolStripMenuItem conversorDeMoedasToolStripMenuItem;
        private ToolStripMenuItem conversorDeTemperaturaToolStripMenuItem;
        private ToolStripMenuItem regraDeTrêsToolStripMenuItem;
        private ToolStripMenuItem sAIRToolStripMenuItem;
        private Label lblCharEqual;
        private Label lblFormulaText;
        private Label lblFormula;
        private TextBox inpTemp2;
        private Label lblFormula2;
    }
}