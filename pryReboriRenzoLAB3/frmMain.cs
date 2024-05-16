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
        int cantidadMeta = 750;
        Random rnd = new Random();
        private bool nivel1Pasado = false;


        private void frmMain_Load(object sender, EventArgs e)
        {
            ObjNavejuegador = new clsNave();
            ObjNavejuegador.CrearJugador();
            Controls.Add(ObjNavejuegador.imgNave);
            ObjNavejuegador.imgNave.Location = new Point(500, 550);
            ObjEnemigo = new clsNave();

            //Enemigo1
            ObjEnemigo.CrearEnemigos();
            Controls.Add(ObjEnemigo.imgNaveEnemiga);
            ObjEnemigo.imgNaveEnemiga.Location = new Point(200, 125);

            //Enemigo1
            ObjEnemigo.CrearEnemigos();
            Controls.Add(ObjEnemigo.imgNaveEnemiga);
            ObjEnemigo.imgNaveEnemiga.Location = new Point(266, 317);

            //Enemigo1
            ObjEnemigo.CrearEnemigos();
            Controls.Add(ObjEnemigo.imgNaveEnemiga);
            ObjEnemigo.imgNaveEnemiga.Location = new Point(800, 250);

            //Enemigo2
            ObjEnemigo.CrearEnemigos();
            Controls.Add(ObjEnemigo.imgNaveEnemiga2);
            ObjEnemigo.imgNaveEnemiga2.Location = new Point(100, 100);

            //Enemigo2
            ObjEnemigo.CrearEnemigos();
            Controls.Add(ObjEnemigo.imgNaveEnemiga2);
            ObjEnemigo.imgNaveEnemiga2.Location = new Point(600, 200);

            //Enemigo2
            ObjEnemigo.CrearEnemigos();
            Controls.Add(ObjEnemigo.imgNaveEnemiga2);
            ObjEnemigo.imgNaveEnemiga2.Location = new Point(860, 124);

            //Enemigo3
            ObjEnemigo.CrearEnemigos();
            Controls.Add(ObjEnemigo.imgNaveEnemiga3);
            ObjEnemigo.imgNaveEnemiga3.Location = new Point(355, 75);

            //Enemigo3
            ObjEnemigo.CrearEnemigos();
            Controls.Add(ObjEnemigo.imgNaveEnemiga3);
            ObjEnemigo.imgNaveEnemiga3.Location = new Point(710, 100);

            //Enemigo3
            ObjEnemigo.CrearEnemigos();
            Controls.Add(ObjEnemigo.imgNaveEnemiga3);
            ObjEnemigo.imgNaveEnemiga3.Location = new Point(555, 335);
        }

        private void frmMain_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X + 30, ObjNavejuegador.imgNave.Location.Y);
            }
            if (e.KeyCode == Keys.Left)
            {
                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X - 30, ObjNavejuegador.imgNave.Location.Y);
            }
        }

        private void frmMain_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X, ObjNavejuegador.imgNave.Location.Y - 30);
            }
            if (e.KeyCode == Keys.Down)
            {

                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X, ObjNavejuegador.imgNave.Location.Y + 30);
            }
        }

        private void frmMain_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {

                Disparo = new PictureBox();
                Disparo.BackColor = Color.Red;
                Disparo.Size = new Size(5, 10);
                Disparo.SizeMode = PictureBoxSizeMode.StretchImage;
                Disparo.ImageLocation = "";

                Disparo.Location = new Point(ObjNavejuegador.imgNave.Location.X + ObjNavejuegador.imgNave.Width / 2 - Disparo.Width / 2, ObjNavejuegador.imgNave.Location.Y);
                Controls.Add(Disparo);
                listaDisparos.Add(Disparo);
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (PictureBox disparo in listaDisparos.ToList())
            {
                if (disparo != null && disparo.Location.Y > 0)
                {
                    disparo.Location = new Point(disparo.Location.X, disparo.Location.Y - 10);

                    // Verificar si el disparo está fuera de los límites del formulario
                    if (disparo.Location.Y <= 0 || disparo.Location.X <= 0 || disparo.Location.X >= this.ClientSize.Width || disparo.Location.Y >= this.ClientSize.Height)
                    {
                        Controls.Remove(disparo);
                        listaDisparos.Remove(disparo);
                        continue; // Continuar con el siguiente disparo sin ejecutar el resto del código dentro del bucle
                    }

                    foreach (Control control in Controls)
                    {
                        if (control is PictureBox && control != disparo)
                        {
                            if (control != ObjNavejuegador.imgNave)
                            {
                                if (disparo.Bounds.IntersectsWith(control.Bounds))
                                {
                                    // Si la bala golpea a un enemigo, elimina tanto la bala como el enemigo
                                    Controls.Remove(disparo);
                                    listaDisparos.Remove(disparo);
                                    Controls.Remove(control);
                                    control.Dispose();

                                    // Incrementa el puntaje
                                    puntaje += 30;
                                    ActualizarPuntaje();

                                    // Llama al método para manejar la muerte del enemigo
                                    ManejarMuerteEnemigo();

                                    // Genera un nuevo enemigo en una posición aleatoria
                                    GenerarNuevoEnemigoAleatorio();

                                    break;
                                }
                            }
                        }
                    }
                }
            }


        }
        private void ActualizarPuntaje()
        {
            // Muestra el puntaje actualizado en algún lugar de tu formulario
            // Por ejemplo, en un label llamado lblPuntaje
            lblPuntaje.Text = "SCORE: " + puntaje.ToString();

            // Verifica si el puntaje alcanza cierta cantidad
            if (puntaje >= cantidadMeta)
            {
                // Muestra un mensaje
                MessageBox.Show("¡Has alcanzado " + cantidadMeta.ToString() + " puntos! ¡Felicidades!");



                // Reinicia el programa
                ReiniciarPrograma();
            }
        }

        private void ReiniciarPrograma()
        {
            
            
            puntaje = 0;
            ActualizarPuntaje(); // Actualizar el puntaje en el formulario
                                 
        }
        private void temporizadorRandom_Tick(object sender, EventArgs e)
        {

        }

        bool generarEnemigos = true;
        int enemigosMuertos = 0;
        private void GenerarNuevoEnemigoAleatorio()
        {
            if (generarEnemigos)
            {
                for (int i = 1; i <= 3; i++)
                {
                    clsNave nuevoEnemigo = new clsNave();
                    nuevoEnemigo.CrearEnemigos();

                    // Generar posiciones aleatorias dentro de los límites del formulario
                    int posX = rnd.Next(0, this.ClientSize.Width - nuevoEnemigo.imgNaveEnemiga.Width);
                    int posY = rnd.Next(0, this.ClientSize.Height / 2);

                    // Establecer la posición del enemigo aleatorio
                    switch (i)
                    {
                        case 1:
                            nuevoEnemigo.imgNaveEnemiga.Location = new Point(posX, posY);
                            Controls.Add(nuevoEnemigo.imgNaveEnemiga);
                            break;
                        case 2:
                            nuevoEnemigo.imgNaveEnemiga2.Location = new Point(posX, posY);
                            Controls.Add(nuevoEnemigo.imgNaveEnemiga2);
                            break;
                        case 3:
                            nuevoEnemigo.imgNaveEnemiga3.Location = new Point(posX, posY);
                            Controls.Add(nuevoEnemigo.imgNaveEnemiga3);
                            break;
                    }
                }
            }
        }
        // Método para manejar la muerte de un enemigo
        private void ManejarMuerteEnemigo()
        {
            enemigosMuertos++;

            // Si se han muerto dos enemigos, desactiva la generación de enemigos
            if (enemigosMuertos >= 5)
            {
                generarEnemigos = false;
            }
        }

        private void lblPuntaje_Click(object sender, EventArgs e)
        {
            
        }
    }
}

