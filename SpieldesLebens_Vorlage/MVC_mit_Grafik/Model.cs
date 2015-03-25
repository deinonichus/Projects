using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC_mit_Grafik
{
    class Model
    {
        //Erzeugen vom 2D- Array
        int[,] gol_alt = new int[10, 10];
        int[,] gol_neu = new int[10, 10];
        //Zugriffsmethoden

        //Lesen
        public int lesen_feld(int x, int y)
        {
            return gol_alt[x, y];
        }

        //Schreiben
        public void  schreiben_feld(int x, int y, int wert)
        {
             gol_neu[x, y]= wert;
        }

        //Umnagern altes Array auf neues array

        public void umlagern()
        {
            gol_alt = gol_neu;
        }

        //Leeren des neuen Arrays

        public void leeren()
        {
            for (int x = 0; x < 9; x++)
            { 
                for (int y = 0; y<9; y++)
                {
                    gol_neu[x,y] = 0;
                }
            }
        }
    }
}
