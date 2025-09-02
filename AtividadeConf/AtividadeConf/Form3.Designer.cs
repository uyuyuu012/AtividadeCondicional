namespace AtividadeConf
{
    partial class Frmaquibancada
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
            this.lbltotpub = new System.Windows.Forms.Label();
            this.btnapagar = new System.Windows.Forms.Button();
            this.bntcalc = new System.Windows.Forms.Button();
            this.bntvoltar = new System.Windows.Forms.Button();
            this.txttotpubli = new System.Windows.Forms.TextBox();
            this.lblrendatot = new System.Windows.Forms.Label();
            this.txtrendatot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltotpub
            // 
            this.lbltotpub.AutoSize = true;
            this.lbltotpub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbltotpub.Location = new System.Drawing.Point(53, 71);
            this.lbltotpub.Name = "lbltotpub";
            this.lbltotpub.Size = new System.Drawing.Size(315, 26);
            this.lbltotpub.TabIndex = 1;
            this.lbltotpub.Text = "Digite o total do público do jogo";
            // 
            // btnapagar
            // 
            this.btnapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnapagar.Location = new System.Drawing.Point(73, 353);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(152, 50);
            this.btnapagar.TabIndex = 3;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            // 
            // bntcalc
            // 
            this.bntcalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.bntcalc.Location = new System.Drawing.Point(335, 353);
            this.bntcalc.Name = "bntcalc";
            this.bntcalc.Size = new System.Drawing.Size(152, 50);
            this.bntcalc.TabIndex = 4;
            this.bntcalc.Text = "Calculo";
            this.bntcalc.UseVisualStyleBackColor = true;
            this.bntcalc.Click += new System.EventHandler(this.bntcalc_Click);
            // 
            // bntvoltar
            // 
            this.bntvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.bntvoltar.Location = new System.Drawing.Point(573, 353);
            this.bntvoltar.Name = "bntvoltar";
            this.bntvoltar.Size = new System.Drawing.Size(152, 50);
            this.bntvoltar.TabIndex = 5;
            this.bntvoltar.Text = "Voltar";
            this.bntvoltar.UseVisualStyleBackColor = true;
            // 
            // txttotpubli
            // 
            this.txttotpubli.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txttotpubli.Location = new System.Drawing.Point(412, 65);
            this.txttotpubli.Name = "txttotpubli";
            this.txttotpubli.Size = new System.Drawing.Size(158, 32);
            this.txttotpubli.TabIndex = 6;
            // 
            // lblrendatot
            // 
            this.lblrendatot.AutoSize = true;
            this.lblrendatot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblrendatot.Location = new System.Drawing.Point(53, 145);
            this.lblrendatot.Name = "lblrendatot";
            this.lblrendatot.Size = new System.Drawing.Size(236, 26);
            this.lblrendatot.TabIndex = 7;
            this.lblrendatot.Text = "A renda total do jogo é:";
            // 
            // txtrendatot
            // 
            this.txtrendatot.Enabled = false;
            this.txtrendatot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtrendatot.Location = new System.Drawing.Point(412, 145);
            this.txtrendatot.Name = "txtrendatot";
            this.txtrendatot.Size = new System.Drawing.Size(158, 32);
            this.txtrendatot.TabIndex = 8;
            // 
            // Frmaquibancada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtrendatot);
            this.Controls.Add(this.lblrendatot);
            this.Controls.Add(this.txttotpubli);
            this.Controls.Add(this.bntvoltar);
            this.Controls.Add(this.bntcalc);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.lbltotpub);
            this.Name = "Frmaquibancada";
            this.Text = "Arquibancada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltotpub;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Button bntcalc;
        private System.Windows.Forms.Button bntvoltar;
        private System.Windows.Forms.TextBox txttotpubli;
        private System.Windows.Forms.Label lblrendatot;
        private System.Windows.Forms.TextBox txtrendatot;
    }
}