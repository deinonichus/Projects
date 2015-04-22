using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_use
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Eventmethoden
        public void bei_eins(object sender, EventArgs e)
        {
            //MessageBox.Show("bin in 1");
            textBox1.Text = "bin in 1";
        }

        public static void bei_zwei(object sender, EventArgs e)
        {
            //MessageBox.Show("bin in 2");
            textBox1.Text = "bin in 2";
        }

        //Bleibt leer
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        //Control-Center der Applikation
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Entscheiden welcher Button gedrückt ist
            if (radioButton1.Checked == true)
            {
                //Button 1 -> Methode Click zuweisen einer 
                //Eventmethode
                button1.Click -= new EventHandler(bei_zwei);
                button1.Click += new EventHandler(bei_eins);
            }
            else
            {
                //Bereits zugewiesene Eventmethode entfernen
                button1.Click -= new EventHandler(bei_eins);
                //Neue Methode zuweisen
                button1.Click += new EventHandler(bei_zwei);
            }
        }
    }
}
