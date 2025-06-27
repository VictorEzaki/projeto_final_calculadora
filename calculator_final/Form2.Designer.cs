namespace calculator_final
{
    partial class Form2
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
            inpPeso = new TextBox();
            lblPeso = new Label();
            lblAltura = new Label();
            inpAltura = new TextBox();
            lblKg = new Label();
            lblCm = new Label();
            btnCalcular = new Button();
            btnLimpar = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // inpPeso
            // 
            inpPeso.Font = new Font("Segoe UI", 16F);
            inpPeso.Location = new Point(45, 73);
            inpPeso.Name = "inpPeso";
            inpPeso.Size = new Size(134, 36);
            inpPeso.TabIndex = 0;
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
            // inpAltura
            // 
            inpAltura.Font = new Font("Segoe UI", 16F);
            inpAltura.Location = new Point(265, 73);
            inpAltura.Name = "inpAltura";
            inpAltura.Size = new Size(134, 36);
            inpAltura.TabIndex = 2;
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
            lblCm.Location = new Point(405, 79);
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
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
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
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 20F);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(346, 205);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 37);
            lblResult.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(lblCm);
            Controls.Add(lblKg);
            Controls.Add(lblAltura);
            Controls.Add(inpAltura);
            Controls.Add(lblPeso);
            Controls.Add(inpPeso);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inpPeso;
        private Label lblPeso;
        private Label lblAltura;
        private TextBox inpAltura;
        private Label lblKg;
        private Label lblCm;
        private Button btnCalcular;
        private Button btnLimpar;
        private Label lblResult;
    }
}