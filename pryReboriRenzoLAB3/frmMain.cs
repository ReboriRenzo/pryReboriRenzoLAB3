using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
namespace pryReboriRenzoLAB3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        clsNave ObjNavejuegador;
        clsNave ObjEnemigo;
        PictureBox Disparo;
        bool espacio = false;
        List<PictureBox> listaDisparos = new List<PictureBox>();
        private int puntaje = 0;
        Random EnemigosAleatorios = new Random();
        Random PosicionX = new Random();
        Random PosicionY = new Random();

        private void frmMain_Load(object sender, EventArgs e)
        {

            ObjNavejuegador = new clsNave();
            ObjNavejuegador.CrearJugador();
            Controls.Add(ObjNavejuegador.imgNave);
            ObjNavejuegador.imgNave.Location = new Point(350, 400);
            ObjEnemigo = new clsNave();

            //Enemigo3
            ObjEnemigo.CrearEnemigos();
            Controls.Add(ObjEnemigo.imgNaveEnemiga);
            ObjEnemigo.imgNaveEnemiga.Location = new Point(500, 150);

            //Enemigo2
            ObjEnemigo.CrearEnemigos();
            Controls.Add(ObjEnemigo.imgNaveEnemiga2);
            ObjEnemigo.imgNaveEnemiga2.Location = new Point(100, 100);

            //Enemigo3
            ObjEnemigo.CrearEnemigos();
            Controls.Add(ObjEnemigo.imgNaveEnemiga3);
            ObjEnemigo.imgNaveEnemiga3.Location = new Point(305, 175);
        }

        private void frmMain_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X + 5, ObjNavejuegador.imgNave.Location.Y);
            }
            if (e.KeyCode == Keys.Left)
            {
                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X - 5, ObjNavejuegador.imgNave.Location.Y);
            }
        }

        private void frmMain_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X, ObjNavejuegador.imgNave.Location.Y - 5);
            }
            if (e.KeyCode == Keys.Down)
            {

                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X, ObjNavejuegador.imgNave.Location.Y + 5);
            }
        }

        private void frmMain_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {

                Disparo = new PictureBox();
                Disparo.BackColor = Color.Black;
                Disparo.Size = new Size(30, 40);
                Disparo.SizeMode = PictureBoxSizeMode.StretchImage;
                Disparo.ImageLocation = "https://img.freepik.com/fotos-premium/imagen-bala-sobre-fondo-negro_908985-50607.jpg";

                Disparo.Location = new Point(ObjNavejuegador.imgNave.Location.X + ObjNavejuegador.imgNave.Width / 2 - Disparo.Width / 2, ObjNavejuegador.imgNave.Location.Y);
                Controls.Add(Disparo);
                listaDisparos.Add(Disparo);
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Itera sobre cada disparo en la lista
            foreach (PictureBox disparo in listaDisparos.ToList())
            {
                if (disparo != null && disparo.Location.Y > 0)
                {
                    disparo.Location = new Point(
                        disparo.Location.X,
                        disparo.Location.Y - 10);

                    // Verifica si hay colisión entre el disparo y algún enemigo
                    foreach (Control control in Controls)
                    {
                        if (control is PictureBox && control != disparo)
                        {
                            // Comprueba que el control no sea la nave del jugador
                            if (control != ObjNavejuegador.imgNave)
                            {
                                // Si la colisión ocurre, elimina tanto al disparo como al enemigo
                                if (disparo.Bounds.IntersectsWith(control.Bounds))
                                {
                                    Controls.Remove(disparo);
                                    listaDisparos.Remove(disparo);
                                    Controls.Remove(control);
                                    control.Dispose();

                                    // Incrementar el puntaje
                                    puntaje += 100;
                                    ActualizarPuntaje(); // Llama a un método para mostrar el puntaje actualizado

                                    break; // Sale del bucle interior para evitar colisiones múltiples
                                }
                            }
                        }
                    }
                }
                else
                {
                    // Si el disparo sale de la pantalla, elimínalo y remuévelo de la lista
                    Controls.Remove(disparo);
                    listaDisparos.Remove(disparo);
                }
            }
        }

        private void ActualizarPuntaje()
        {
            // Muestra el puntaje actualizado en algún lugar de tu formulario
            // Por ejemplo, en un label llamado lblPuntaje
            lblPuntaje.Text = "PUNTAJE: " + puntaje.ToString();
        }
    }
    
}