namespace AtividadeConf
{
    partial class frmlanches
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
            this.lblcoditem = new System.Windows.Forms.Label();
            this.lblnomeproduto = new System.Windows.Forms.Label();
            this.lblvalorproduto = new System.Windows.Forms.Label();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnapagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcoditem
            // 
            this.lblcoditem.AutoSize = true;
            this.lblcoditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblcoditem.Location = new System.Drawing.Point(12, 90);
            this.lblcoditem.Name = "lblcoditem";
            this.lblcoditem.Size = new System.Drawing.Size(371, 26);
            this.lblcoditem.TabIndex = 0;
            this.lblcoditem.Text = "Digite o código do produto desejado: ";
            // 
            // lblnomeproduto
            // 
            this.lblnomeproduto.AutoSize = true;
            this.lblnomeproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblnomeproduto.Location = new System.Drawing.Point(12, 211);
            this.lblnomeproduto.Name = "lblnomeproduto";
            this.lblnomeproduto.Size = new System.Drawing.Size(198, 26);
            this.lblnomeproduto.TabIndex = 1;
            this.lblnomeproduto.Text = "Você escolheu um ";
            // 
            // lblvalorproduto
            // 
            this.lblvalorproduto.AutoSize = true;
            this.lblvalorproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblvalorproduto.Location = new System.Drawing.Point(365, 211);
            this.lblvalorproduto.Name = "lblvalorproduto";
            this.lblvalorproduto.Size = new System.Drawing.Size(106, 26);
            this.lblvalorproduto.TabIndex = 2;
            this.lblvalorproduto.Text = "que custa";
            // 
            // txtproduto
            // 
            this.txtproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtproduto.Location = new System.Drawing.Point(202, 208);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(157, 32);
            this.txtproduto.TabIndex = 3;
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtpreco.Location = new System.Drawing.Point(477, 208);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(157, 32);
            this.txtpreco.TabIndex = 4;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtcodigo.Location = new System.Drawing.Point(380, 87);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 32);
            this.txtcodigo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button1.Location = new System.Drawing.Point(310, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnvoltar.Location = new System.Drawing.Point(583, 337);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(170, 70);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // btnapagar
            // 
            this.btnapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnapagar.Location = new System.Drawing.Point(40, 337);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(170, 70);
            this.btnapagar.TabIndex = 8;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            // 
            // frmlanches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.lblvalorproduto);
            this.Controls.Add(this.lblnomeproduto);
            this.Controls.Add(this.lblcoditem);
            this.Name = "frmlanches";
            this.Text = "Lanches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcoditem;
        private System.Windows.Forms.Label lblnomeproduto;
        private System.Windows.Forms.Label lblvalorproduto;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnapagar;
    }
}