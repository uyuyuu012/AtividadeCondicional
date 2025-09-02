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
    public partial class Frmaquibancada : Form
    {
        public Frmaquibancada()
        {
            InitializeComponent();
        }

        double rendatot, rdp, rdg, rda, rdc;
        private void bntcalc_Click(object sender, EventArgs e)
        {
            double popular, geral, arquibancada, cadeiras, totpubli;

            totpubli = Convert.ToDouble(txttotpubli.Text);

            popular = totpubli * 0.1;
            geral = totpubli * 0.5;
            arquibancada = totpubli * 0.3;
            cadeiras = totpubli * 0.1;


            if (popular > 0) {
                rdp = popular * 5;
            }
            if (geral > 0)
            {
                rdg = geral * 10;
            }
            if (arquibancada > 0)
            {
                rda = arquibancada * 20;
            }
            if (cadeiras > 0)
            {
                rdc = cadeiras * 30;
            }

            rendatot = rda + rdc + rdg + rdp;

            txtrendatot.Text = rendatot.ToString(); 



        }
    }
}
