namespace calculator_final
{
    partial class FormIMC
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
            lblPeso = new Label();
            lblAltura = new Label();
            lblKg = new Label();
            lblCm = new Label();
            btnCalcular = new Button();
            btnLimpar = new Button();
            lblResult = new Label();
            inpAltura = new MaskedTextBox();
            inpPeso = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            mnsMenu = new MenuStrip();
            calculadoraIMCToolStripMenuItem = new ToolStripMenuItem();
            conversorºCToolStripMenuItem = new ToolStripMenuItem();
            iMCToolStripMenuItem = new ToolStripMenuItem();
            conversorDeMoedasToolStripMenuItem = new ToolStripMenuItem();
            conversorDeTemperaturaToolStripMenuItem = new ToolStripMenuItem();
            regraDeTrêsToolStripMenuItem = new ToolStripMenuItem();
            sAIRToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            mnsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 16F);
            lblPeso.ForeColor = Color.White;
            lblPeso.Location = new Point(45, 40);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(58, 30);
            lblPeso.TabIndex = 1;
            lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 16F);
            lblAltura.ForeColor = Color.White;
            lblAltura.Location = new Point(265, 40);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(70, 30);
            lblAltura.TabIndex = 3;
            lblAltura.Text = "Altura";
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;
            lblKg.Font = new Font("Segoe UI", 16F);
            lblKg.ForeColor = Color.White;
            lblKg.Location = new Point(185, 79);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(40, 30);
            lblKg.TabIndex = 4;
            lblKg.Text = "KG";
            // 
            // lblCm
            // 
            lblCm.AutoSize = true;
            lblCm.Font = new Font("Segoe UI", 16F);
            lblCm.ForeColor = Color.White;
            lblCm.Location = new Point(403, 79);
            lblCm.Name = "lblCm";
            lblCm.Size = new Size(47, 30);
            lblCm.TabIndex = 5;
            lblCm.Text = "CM";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(40, 167, 69);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 12F);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(622, 59);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(134, 50);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            btnCalcular.KeyDown += btnCalcular_KeyDown;
            btnCalcular.KeyPress += btnCalcular_KeyPress;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(228, 103, 83);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 12F);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(482, 59);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(134, 50);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 20F);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(400, 170);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 37);
            lblResult.TabIndex = 8;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inpAltura
            // 
            inpAltura.Font = new Font("Segoe UI", 16F);
            inpAltura.Location = new Point(265, 73);
            inpAltura.Mask = "0.00";
            inpAltura.Name = "inpAltura";
            inpAltura.Size = new Size(132, 36);
            inpAltura.TabIndex = 1;
            inpAltura.ValidatingType = typeof(DateTime);
            inpAltura.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            inpAltura.KeyDown += inpAltura_KeyDown;
            inpAltura.KeyPress += inpAltura_KeyPress;
            // 
            // inpPeso
            // 
            inpPeso.Font = new Font("Segoe UI", 16F);
            inpPeso.Location = new Point(45, 73);
            inpPeso.Name = "inpPeso";
            inpPeso.Size = new Size(134, 36);
            inpPeso.TabIndex = 0;
            inpPeso.KeyDown += inpPeso_KeyDown;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 1, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(label8, 1, 3);
            tableLayoutPanel1.Controls.Add(label9, 0, 4);
            tableLayoutPanel1.Controls.Add(label10, 1, 4);
            tableLayoutPanel1.Controls.Add(label11, 0, 5);
            tableLayoutPanel1.Controls.Add(label12, 1, 5);
            tableLayoutPanel1.Controls.Add(label13, 0, 6);
            tableLayoutPanel1.Controls.Add(label14, 1, 6);
            tableLayoutPanel1.Controls.Add(label15, 0, 7);
            tableLayoutPanel1.Controls.Add(label16, 1, 7);
            tableLayoutPanel1.Controls.Add(label17, 0, 8);
            tableLayoutPanel1.Controls.Add(label18, 1, 8);
            tableLayoutPanel1.Location = new Point(193, 250);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(414, 182);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.FromArgb(0, 65, 134);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 21);
            label1.TabIndex = 0;
            label1.Text = "IMC (KG/M²)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.Dock = DockStyle.Fill;
            label2.ForeColor = Color.FromArgb(0, 65, 134);
            label2.Location = new Point(210, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 21);
            label2.TabIndex = 1;
            label2.Text = "Classificação";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 21);
            label3.Name = "label3";
            label3.Size = new Size(201, 21);
            label3.TabIndex = 2;
            label3.Text = "Menor de 18,5";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(210, 21);
            label4.Name = "label4";
            label4.Size = new Size(201, 21);
            label4.TabIndex = 3;
            label4.Text = "Abaixo do peso";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 42);
            label5.Name = "label5";
            label5.Size = new Size(201, 20);
            label5.TabIndex = 4;
            label5.Text = "18,5 a 24,9";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Silver;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(210, 42);
            label6.Name = "label6";
            label6.Size = new Size(201, 20);
            label6.TabIndex = 5;
            label6.Text = "Peso normal";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 62);
            label7.Name = "label7";
            label7.Size = new Size(201, 20);
            label7.TabIndex = 6;
            label7.Text = "25 a 29,9";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(210, 62);
            label8.Name = "label8";
            label8.Size = new Size(201, 20);
            label8.TabIndex = 7;
            label8.Text = "SobrePeso";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Silver;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 82);
            label9.Name = "label9";
            label9.Size = new Size(201, 20);
            label9.TabIndex = 8;
            label9.Text = "30 a 34,9";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Silver;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(210, 82);
            label10.Name = "label10";
            label10.Size = new Size(201, 20);
            label10.TabIndex = 9;
            label10.Text = "Obesidade grau I";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(3, 102);
            label11.Name = "label11";
            label11.Size = new Size(201, 20);
            label11.TabIndex = 10;
            label11.Text = "35 a 39,9";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(210, 102);
            label12.Name = "label12";
            label12.Size = new Size(201, 20);
            label12.TabIndex = 11;
            label12.Text = "Obesidade grau II";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Silver;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(3, 122);
            label13.Name = "label13";
            label13.Size = new Size(201, 20);
            label13.TabIndex = 12;
            label13.Text = "40 a 49,9";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Silver;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(210, 122);
            label14.Name = "label14";
            label14.Size = new Size(201, 20);
            label14.TabIndex = 13;
            label14.Text = "Obesidade grau III";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Dock = DockStyle.Fill;
            label15.Location = new Point(3, 142);
            label15.Name = "label15";
            label15.Size = new Size(201, 20);
            label15.TabIndex = 14;
            label15.Text = "50 a 59,9";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Dock = DockStyle.Fill;
            label16.Location = new Point(210, 142);
            label16.Name = "label16";
            label16.Size = new Size(201, 20);
            label16.TabIndex = 15;
            label16.Text = "Obesidade grau IV";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Silver;
            label17.Dock = DockStyle.Fill;
            label17.Location = new Point(3, 162);
            label17.Name = "label17";
            label17.Size = new Size(201, 20);
            label17.TabIndex = 16;
            label17.Text = "Acima de 60";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Silver;
            label18.Dock = DockStyle.Fill;
            label18.Location = new Point(210, 162);
            label18.Name = "label18";
            label18.Size = new Size(201, 20);
            label18.TabIndex = 17;
            label18.Text = "Obesidade grau V";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mnsMenu
            // 
            mnsMenu.BackColor = Color.Transparent;
            mnsMenu.Items.AddRange(new ToolStripItem[] { calculadoraIMCToolStripMenuItem });
            mnsMenu.Location = new Point(0, 0);
            mnsMenu.Name = "mnsMenu";
            mnsMenu.Size = new Size(800, 24);
            mnsMenu.TabIndex = 21;
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
            // FormIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(mnsMenu);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(inpAltura);
            Controls.Add(lblResult);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(lblCm);
            Controls.Add(lblKg);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Controls.Add(inpPeso);
            Name = "FormIMC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IMC";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            mnsMenu.ResumeLayout(false);
            mnsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPeso;
        private Label lblAltura;
        private Label lblKg;
        private Label lblCm;
        private Button btnCalcular;
        private Button btnLimpar;
        private Label lblResult;
        private MaskedTextBox inpAltura;
        private TextBox inpPeso;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private MenuStrip mnsMenu;
        private ToolStripMenuItem calculadoraIMCToolStripMenuItem;
        private ToolStripMenuItem conversorºCToolStripMenuItem;
        private ToolStripMenuItem conversorDeMoedasToolStripMenuItem;
        private ToolStripMenuItem conversorDeTemperaturaToolStripMenuItem;
        private ToolStripMenuItem regraDeTrêsToolStripMenuItem;
        private ToolStripMenuItem sAIRToolStripMenuItem;
        private ToolStripMenuItem iMCToolStripMenuItem;
    }
}