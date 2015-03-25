

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Zusätzlicher Namespace
using System.Drawing;
using System.Windows.Forms;

namespace MVC_mit_Grafik
{
    class Control
    {
        //Instanz auf Model
        Model my_mdl = new Model();

        //Methode zum initialisieren der matrix
        public void init_matrix()
        {
            //Rand zu Null setzen
            //Erste Zeile
            for (int i = 0; i < 10; i++)
            {
                my_mdl.schreiben_feld(i, 0, 0);
            }

            //Letzte Zeile
            for (int i = 0; i < 10; i++)
            {
                my_mdl.schreiben_feld(i, 9, 0);
            }

            //Erste Spalte
            for (int i = 0; i < 10; i++)
            {
                my_mdl.schreiben_feld(0, i, 0);
            }

            //letzte Spalte
            for (int i = 0; i < 10; i++)
            {
                my_mdl.schreiben_feld(9, i, 0);
            }

            //Inhalt mittels Zufallszahl setzen
            Random my_rnd = new Random();
            double zufall = 0;

            //alle x
            for (int x = 1; x < 9; x++)
            {
                //alle y
                for (int y = 1; y < 9; y++)
                {
                    //Zufallszahl erzeugen
                    zufall = my_rnd.Next(0,100);

                    //Unterscheiden ob 0 oder 1 geschrieben wird
                    if (zufall > 70)
                    {
                        my_mdl.schreiben_feld(x, y, 1);
                    }
                    else
                    {
                        my_mdl.schreiben_feld(x, y, 0);
                    }
                }
           }

            //umlagern neue in alte Matrix
            my_mdl.umlagern();
        }

        //methode zum aendern der Picturebox
        public void aendere_picturebox(PictureBox my_box)
        {
            //erzeugen Grafikoberfläche
            Graphics my_g = my_box.CreateGraphics();
            //Inhalt erzeugen
            
        }

        //Methode zum Anzeigen der Inhalte der Matrix
        public void zeige_matrix_an(PictureBox my_box)
        {
            //erzeugen Grafikoberfläche
            Graphics my_g = my_box.CreateGraphics();

            int inhalt = 0;

            //Inhalt erzeugen

            //Alle x und y Elemente der Matrix auslesen
            for (int x = 1; x < 9; x++)
            {
                for (int y = 1; y < 9; y++)
                {
                    //Matrixelement auslesen
                    inhalt = my_mdl.lesen_feld(x, y);

                    //Rechteck setzen in Picturebox
                    if (inhalt == 1)
                    {
                        my_g.FillRectangle(new SolidBrush(Color.Red), x * 10, y * 10, 10, 10);
                    }
                    else
                    {
                        my_g.FillRectangle(new SolidBrush(Color.White), x * 10, y * 10, 10, 10);
                    }
                }
            }
        }

        //Methode, welche die Anzahl der lebenden Nachbarn ^bestimmt
        public int anzahl_nachbarn(int x, int y)
        { 
            //Lokale Variable summe
            int summe = 0;

            //2 geschachtelte For-Schleifen - aktueller wert bestimmen
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    summe += my_mdl.lesen_feld(i, j);
                }
            }

            //abtiehen des eigenen wertes des Feldes
            return summe - my_mdl.lesen_feld(x, y);

        }
    }
}
