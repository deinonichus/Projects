using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_use
{
    //Deklaration Delegate
    delegate double my_cal_del(double x, double y);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Methodendefinitionen
        //Addieren
        public double addieren(double x, double y)
        {
            return x + y;
        }

        //Multiplizieren
        public double multiplizieren(double x, double y)
        {
            return x * y;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Methode, welche Delegates nutzt

            //instantiieren
            my_cal_del my_del;

            //Addieren??
            if (radioButton1.Checked == true)
            {
                //Zuweisen des methodenzeigers zur methode
                my_del = addieren;
            }
            else
            {
                //dann multiplizieren
                my_del = multiplizieren;
            }

            //Aufrufen der Methode mittels dem Methodenzeiger
            try
            {
                //Wandeln in double
                double zahl1 = Convert.ToDouble(textBox1.Text);
                double zahl2 = Convert.ToDouble(textBox2.Text);

                //Aufrufen
                textBox3.Text = "" + my_del(zahl1, zahl2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
