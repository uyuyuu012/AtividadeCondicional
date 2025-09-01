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
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double livros, preco;
            preco = Convert.ToDouble(txtpreco.Text);
            livros = Convert.ToDouble(txtlivros.Text);

            if (livros <= 10)
            {
                preco = livros * 12;

            }
            else if (livros > 10)
            {
                preco = livros * 8;
            }


        }
    }
}
