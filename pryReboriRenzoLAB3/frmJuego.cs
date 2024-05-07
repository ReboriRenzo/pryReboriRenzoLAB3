using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryReboriRenzoLAB3
{
    public partial class frmJuego : Form
    {
        clsNave objNave;
        public frmJuego()
        {
            InitializeComponent();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNave = new clsNave();
            objNave.CrearJugador();
            objNave.imgNave.Location = new Point(250, 600);
            Controls.Add(objNave.imgNave);

            objNave.CrearEnemigos();
            objNave.imgNave.Location = new Point(150, 150);
            Controls.Add(objNave.imgNave);
            objNave.CrearEnemigos2();
            objNave.imgNave.Location = new Point(120, 200);
            Controls.Add(objNave.imgNave);
            objNave.CrearEnemigos3();
            objNave.imgNave.Location = new Point(100, 180);
            Controls.Add(objNave.imgNave);
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                objNave.imgNave.Location = new Point(objNave.imgNave.Location.X + 5, objNave.imgNave.Location.Y);

            }
            if(e.KeyCode==Keys.Left)
            {
                objNave.imgNave.Location = new Point(objNave.imgNave.Location.X - 5, objNave.imgNave.Location.Y);
            }
        }
    }
}
