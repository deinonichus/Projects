using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mit_MVC
{
    public partial class Form1 : Form
    {
        //Instanz des Control
        Control my_ctrl = new Control();

        public Form1()
        {
            InitializeComponent();
        }

        //Methode zum Schreiben
        private void button1_Click(object sender, EventArgs e)
        {
            //Schreiben
            my_ctrl.nehme_daten_entgegen(textBox1.Text, textBox2.Text);
        }


        //Methode zum Lesen der Daten
        private void button2_Click(object sender, EventArgs e)
        {
            //Name holen
            textBox1.Text = my_ctrl.hole_daten_name_real();

        }
    }
}
