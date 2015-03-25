
/*
 * Grafik in C#
 * Erstes Beispiel
 * 
 * Autor:   P. Hüssy
 * Datum:   08.12.2011
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace erste_Grafik
{
    public partial class Form1 : Form
    {
        //Eigenschaft erzeugen
        Graphics my_g;

        public Form1()
        {
            InitializeComponent();
        }

        //Graphische Oberfläche schaffen
        public void erzeuge_grafik()
        {
            //Eigenschaft
            int zaehler=1;

            //Erzeugt eine Oberfläche, welche graphische Befehle annimmt
            Graphics my_g = this.CreateGraphics();

            //Erzeugen eines Rechteckes
                 //Form
                                //Farbe
                                                            //x-Koordinate
                                                                  //y-Koordinate
                                                                       //Breite
                                                                           //Höhe

            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if ((zaehler % 2)==1)
                    {
                        my_g.FillRectangle(new SolidBrush(Color.Yellow), 100 + x * 20, 50 + y * 20, 20, 20);
                    }
                    else
                    {
                        my_g.FillRectangle(new SolidBrush(Color.Blue), 100 + x * 20, 50 + y * 20, 20, 20);
                    }

                    //Zaehler erhöhen
                    zaehler++;
                }
                //Zaehler erhöhen
                zaehler++;
            }
            //
           
        }

        //Methode des Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            //Aufrufen
            erzeuge_grafik();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
