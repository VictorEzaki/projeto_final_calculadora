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
            // FormConversorMoedas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(800, 450);
            Controls.Add(mnsMenu);
            Name = "FormConversorMoedas";
            Text = "Form3";
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
    }
}