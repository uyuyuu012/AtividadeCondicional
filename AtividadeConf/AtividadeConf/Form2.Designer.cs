namespace AtividadeConf
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquibancadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliotecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lanchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoIMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquibancadaToolStripMenuItem,
            this.bibliotecaToolStripMenuItem,
            this.salárioToolStripMenuItem,
            this.lanchesToolStripMenuItem,
            this.calculoIMCToolStripMenuItem});
            this.programasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(124, 34);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // arquibancadaToolStripMenuItem
            // 
            this.arquibancadaToolStripMenuItem.Name = "arquibancadaToolStripMenuItem";
            this.arquibancadaToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.arquibancadaToolStripMenuItem.Text = "Arquibancada";
            this.arquibancadaToolStripMenuItem.Click += new System.EventHandler(this.arquibancadaToolStripMenuItem_Click);
            // 
            // bibliotecaToolStripMenuItem
            // 
            this.bibliotecaToolStripMenuItem.Name = "bibliotecaToolStripMenuItem";
            this.bibliotecaToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.bibliotecaToolStripMenuItem.Text = "Biblioteca";
            this.bibliotecaToolStripMenuItem.Click += new System.EventHandler(this.bibliotecaToolStripMenuItem_Click);
            // 
            // salárioToolStripMenuItem
            // 
            this.salárioToolStripMenuItem.Name = "salárioToolStripMenuItem";
            this.salárioToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.salárioToolStripMenuItem.Text = "Salário";
            this.salárioToolStripMenuItem.Click += new System.EventHandler(this.salárioToolStripMenuItem_Click);
            // 
            // lanchesToolStripMenuItem
            // 
            this.lanchesToolStripMenuItem.Name = "lanchesToolStripMenuItem";
            this.lanchesToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.lanchesToolStripMenuItem.Text = "Lanches";
            this.lanchesToolStripMenuItem.Click += new System.EventHandler(this.lanchesToolStripMenuItem_Click);
            // 
            // calculoIMCToolStripMenuItem
            // 
            this.calculoIMCToolStripMenuItem.Name = "calculoIMCToolStripMenuItem";
            this.calculoIMCToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.calculoIMCToolStripMenuItem.Text = "Calculo IMC";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(61, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquibancadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliotecaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lanchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoIMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}