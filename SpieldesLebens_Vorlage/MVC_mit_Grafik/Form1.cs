using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVC_mit_Grafik
{
    public partial class Form1 : Form
    {
        //Instanz vom Control
        Control my_ctrl = new Control();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aufruf
            //my_ctrl.aendere_picturebox(pictureBox1);
            my_ctrl.zeige_matrix_an(pictureBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Intitaliseren der Matrix
            my_ctrl.init_matrix();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            //Check eines eckpunkt
            int test = my_ctrl.anzahl_nachbarn(1, 1);
        }
    }
}
