using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace pryReboriRenzoLAB3
{
    public partial class frmFirma : Form
    {
        private Bitmap Imagen;
        public frmFirma()
        {
            InitializeComponent();
            Imagen = new Bitmap(pictureBox1.Width, pictureBox1.Height); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics oG = Graphics.FromImage(Imagen))
                {
                    oG.FillEllipse(Brushes.Red, e.X, e.Y, 5, 5);
                }
                pictureBox1.Image = Imagen;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Imagen.Save("Firma.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("La firma se guardo con EXITO");
            this.Close();
        }
    }
}
