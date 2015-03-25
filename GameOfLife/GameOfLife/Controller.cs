using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameOfLife {
    class Controller {
        public Controller() {

        }
        private Graphics board = new Graphics();

        public void drawBoard() {
            
        }

        ////erzeugen Grafikoberfläche
            //Graphics my_g = my_box.CreateGraphics();

            //int inhalt = 0;

            ////Inhalt erzeugen

            ////Alle x und y Elemente der Matrix auslesen
            //for (int x = 1; x < 9; x++)
            //{
            //    for (int y = 1; y < 9; y++)
            //    {
            //        //Matrixelement auslesen
            //        inhalt = my_mdl.lesen_feld(x, y);

            //        //Rechteck setzen in Picturebox
            //        if (inhalt == 1)
            //        {
            //            my_g.FillRectangle(new SolidBrush(Color.Red), x * 10, y * 10, 10, 10);
            //        }
            //        else
            //        {
            //            my_g.FillRectangle(new SolidBrush(Color.White), x * 10, y * 10, 10, 10);
            //        }
            //    }
            //}

    }
}
