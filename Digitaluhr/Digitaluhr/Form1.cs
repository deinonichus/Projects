using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitaluhr
{
    public partial class Form1 : Form
    {
        //Statusvariable
        static int status = 0; //laufend

        //Eventmethoden

        public void Stunden_stellen(object sender, EventArgs e)
        {
            //Anzeige nach int konvertieren
            int stunde = Convert.ToInt32(textBox1.Text);

            //Gesteuertes Hochzählen
            stunde++;
            stunde = (stunde) % 24;

            //Anzeigen
            textBox1.Text = "" + stunde;

        }

        public  void Minuten_stellen(object sender, EventArgs e)
        {
            //Anzeige nach int konvertieren
            int minute = Convert.ToInt32(textBox2.Text);

            //Gesteuertes Hochzählen
            minute++;
            minute = (minute) % 60;

            //Anzeigen
            textBox2.Text = "" + minute ;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checken auf laufend
            if (status == 0)
            {
                //Wechsel zu Stunden stellen
                button2.Click += new EventHandler(Stunden_stellen);
                status++;
            }
            else if (status == 1)
            {
                //Wechsel zu Minuten stellen
                button2.Click -= new EventHandler(Stunden_stellen);
                button2.Click += new EventHandler(Minuten_stellen);
                status++;
            }
            else
            {
                //Zurück zu laufend
                status = 0;
                //Entfernen Minuten handler
                button2.Click -= new EventHandler(Minuten_stellen);
            }
        }

        //Aktivierungsmethode
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
