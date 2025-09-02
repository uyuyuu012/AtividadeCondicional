using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeConf
{
    public partial class frmsalario : Form
    {
        public frmsalario()
        {
            InitializeComponent();
        }

        double novosalario;

        private void button1_Click(object sender, EventArgs e)
        {
            string nome, sexo;
            double idade, salarioatual;

            nome = txtname.Text;
            sexo = txtsexo.Text;
            idade = Convert.ToDouble(txtidade.Text);
            salarioatual = Convert.ToDouble(txtsalarioatual.Text);
            

             if (sexo.Equals("masculino") && idade >= 30) 
              {
                novosalario = salarioatual + 100;
              }
             if (sexo.Equals("Masculino") && idade < 30)
              {
                novosalario = salarioatual + 50;
              }
             if (sexo.Equals("Feminino") && idade >= 30)
              {
                novosalario = salarioatual + 200;
              }
             if (sexo.Equals("Feminino") && idade < 30)
              {
                novosalario = salarioatual + 150;
              }

            txtnovosalario.Text = Convert.ToString(novosalario);
            txtnome2.Text = nome;
            


        }

    }
}
