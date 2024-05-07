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
            nombre = "Jugador1";
            puntosDeDaños = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://www.bing.com/images/search?view=detailV2&ccid=ra0aMEca&id=48F62745701D96A6716291DB652EFF19791547E3&thid=OIP.ra0aMEcamcoXwrW_QVFgxQHaFW&mediaurl=https%3a%2f%2fwww.vhv.rs%2fdpng%2fd%2f488-4889272_galaga-pixel-art-hd-png-download.png&cdnurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.adad1a30471a99ca17c2b5bf415160c5%3frik%3d40cVeRn%252fLmXbkQ%26pid%3dImgRaw%26r%3d0&exph=621&expw=860&q=GALAGA+IMAGENES&simid=608044989035731287&FORM=IRPRST&ck=265B7799496EBA8C1484828B33EE15E8&selectedIndex=40&itb=0";
        }
        public void CrearEnemigos()
        {

            //CREAR ENEMIGOS CON VIDA LOS PUNTOS DE DAÑO Y CADA UNO CON SU IMAGEN
            vida = 10;
            nombre = "Enemigo1";
            puntosDeDaños = 10;
            imgNaveEnemiga = new PictureBox();
            imgNaveEnemiga.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga.ImageLocation = "https://www.pngwing.com/es/free-png-njood";

            vida = 20;
            nombre = "Enemigo2";
            puntosDeDaños = 100;
            imgNaveEnemiga2 = new PictureBox();
            imgNaveEnemiga2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga2.ImageLocation = "https://www.pngwing.com/es/free-png-zcgzm";

            vida = 30;
            nombre = "Enemigo3";
            puntosDeDaños = 100;
            imgNaveEnemiga3 = new PictureBox();
            imgNaveEnemiga3.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga3.ImageLocation = "https://www.pngwing.com/es/free-png-ygrqb";

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
