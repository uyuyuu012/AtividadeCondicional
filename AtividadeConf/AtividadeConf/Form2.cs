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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void bibliotecaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBiblioteca biblioteca = new FrmBiblioteca();
            biblioteca.Show();
            

        }

        private void arquibancadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Frmaquibancada arquibancada = new Frmaquibancada();
            arquibancada.Show();
        }

        private void salárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmsalario salario = new frmsalario();
            salario.Show();
        }

        private void lanchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmlanches lanches = new frmlanches();
            lanches.Show();
        }
    }
}
