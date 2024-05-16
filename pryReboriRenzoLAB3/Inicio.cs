using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryReboriRenzoLAB3
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            frmFirma Firma = new frmFirma();
            Firma.ShowDialog();
        }

        private void btnGalaga_Click(object sender, EventArgs e)
        {
            frmMain Main = new frmMain();
            Main.ShowDialog();
        }
    }
}
