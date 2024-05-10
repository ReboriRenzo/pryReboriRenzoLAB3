using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryReboriRenzoLAB3
{
    class clsNave
    {
        public string nombre;
        public int vida;
        int puntosDeDaños;
        public PictureBox imgdisparo;
        public PictureBox imgNave;
        public PictureBox imgNaveEnemiga;
        public PictureBox imgNaveEnemiga2;
        public PictureBox imgNaveEnemiga3;


        public void CrearJugador()
        {
            vida = 100;
            nombre = "Mi nave RENZO";
            puntosDeDaños = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://art.pixilart.com/ae81e5e14ff674d.gif";
        }
        public void CrearEnemigos()
        {

            //CREAR ENEMIGOS CON VIDA LOS PUNTOS DE DAÑO Y CADA UNO CON SU IMAGEN
            vida = 10;
            nombre = "Enemigo1";
            puntosDeDaños = 10;
            imgNaveEnemiga = new PictureBox();
            imgNaveEnemiga.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga.ImageLocation = "https://i.gifer.com/MvA.gif";

            vida = 20;
            nombre = "Enemigo2";
            puntosDeDaños = 100;
            imgNaveEnemiga2 = new PictureBox();
            imgNaveEnemiga2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga2.ImageLocation = "https://gifdb.com/images/high/galaga-blue-bug-alien-zc52r4kke3ayd4jy.gif";

            vida = 30;
            nombre = "Enemigo3";
            puntosDeDaños = 100;
            imgNaveEnemiga3 = new PictureBox();
            imgNaveEnemiga3.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga3.ImageLocation = "https://gifdb.com/images/thumbnail/galaga-boss-1000-hit-wwrjpsiqh7cbi97u.gif";


        }

        public void Disparo()
        {
            // VA A SER EL DISPARO QUE SALE DESDE NUESTRA NAVE CON UN NUEVO PICTUREBOX CON SU TAMAÑO Y SU AJUSTE
            imgdisparo = new PictureBox();
            imgdisparo.ImageLocation = "";
            imgdisparo.Size = new Size(15, 15); 
            imgdisparo.SizeMode = PictureBoxSizeMode.StretchImage; 

        }
    }
}
