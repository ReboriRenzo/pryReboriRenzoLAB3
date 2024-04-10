using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace pryReboriRenzoLAB3
{
    class clsNave
    {
        int vida;
        string nombre;
        int puntosDaño;
        public PictureBox imgNave;
        public void CrearJugador()
        {
            vida = 100;
            nombre = "MI NAVE RENZI";
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://es.pngtree.com/freepng/ufo-cartoon-ufo-alien-spaceship_7907398.html";
        }
        public void CrearEnemigos()
        {
            vida = 50;
            nombre = "Nave Enemiga comùn";
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://es.pngtree.com/freepng/cartoon-spaceship-element_4498783.html";
        }

        public void CrearEnemigos2()
        {
            vida = 35;
            nombre = "Nave Enemiga Simple";
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://es.pngtree.com/freepng/pink-spaceship-cartoon-alien-spaceship-overturned-spaceship-landing-spaceship_3899887.html";
        }
        public void CrearEnemigos3()
        {
            vida = 70;
            nombre = "Nave Enemiga Pesada";
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://es.pngtree.com/freepng/pink-spaceship-cartoon-alien-spaceship-overturned-spaceship-landing-spaceship_3899887.html";
        }
    }
}
