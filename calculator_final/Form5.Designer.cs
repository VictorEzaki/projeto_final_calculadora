namespace calculator_final
{
    partial class FormRegraTres
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
            inpNum1 = new TextBox();
            inpNum3 = new TextBox();
            inpNum2 = new TextBox();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            conversorDeTemperaturaToolStripMenuItem.Click += conversorDeTemperaturaToolStripMenuItem_Click;
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
            sAIRToolStripMenuItem.Click += sAIRToolStripMenuItem_Click;
            // 
            // inpNum1
            // 
            inpNum1.Font = new Font("Segoe UI", 16F);
            inpNum1.Location = new Point(208, 126);
            inpNum1.Name = "inpNum1";
            inpNum1.Size = new Size(136, 36);
            inpNum1.TabIndex = 27;
            inpNum1.KeyPress += inpNum1_KeyPress;
            // 
            // inpNum3
            // 
            inpNum3.Font = new Font("Segoe UI", 16F);
            inpNum3.Location = new Point(208, 216);
            inpNum3.Name = "inpNum3";
            inpNum3.Size = new Size(136, 36);
            inpNum3.TabIndex = 29;
            inpNum3.TextChanged += inpNum3_TextChanged;
            inpNum3.KeyPress += inpNum3_KeyPress;
            // 
            // inpNum2
            // 
            inpNum2.Font = new Font("Segoe UI", 16F);
            inpNum2.Location = new Point(456, 126);
            inpNum2.Name = "inpNum2";
            inpNum2.Size = new Size(136, 36);
            inpNum2.TabIndex = 28;
            inpNum2.TextChanged += inpNum2_TextChanged;
            inpNum2.KeyPress += inpNum2_KeyPress;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.FromArgb(60, 125, 144);
            lblResult.Font = new Font("Segoe UI", 16F);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(456, 216);
            lblResult.MinimumSize = new Size(136, 36);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(136, 36);
            lblResult.TabIndex = 30;
            lblResult.Text = "X";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Click += lblResult_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 136);
            label1.MinimumSize = new Size(100, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 31;
            label1.Text = "ESTÁ PARA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(359, 184);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 32;
            label2.Text = "ASSIM COMO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(191, 191, 191);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(350, 136);
            label3.MinimumSize = new Size(100, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 2, 0, 2);
            label3.Size = new Size(100, 19);
            label3.TabIndex = 31;
            label3.Text = "ESTÁ PARA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(191, 191, 191);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(350, 225);
            label4.MinimumSize = new Size(100, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 2, 0, 2);
            label4.Size = new Size(100, 19);
            label4.TabIndex = 33;
            label4.Text = "ESTÁ PARA";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(40, 167, 69);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 12F);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(335, 284);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(131, 40);
            btnCalcular.TabIndex = 30;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += button1_Click;
            // 
            // FormRegraTres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnCalcular);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(inpNum2);
            Controls.Add(inpNum3);
            Controls.Add(inpNum1);
            Controls.Add(mnsMenu);
            Name = "FormRegraTres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Regra de três";
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
        private TextBox inpNum1;
        private TextBox inpNum3;
        private TextBox inpNum2;
        private Label lblResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCalcular;
    }
}