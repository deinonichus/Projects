using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//zusätzliche Namespaces
using System.Threading;
using System.Diagnostics;
using System.Media;


namespace Thread1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Hauptmethode
        private void button1_Click(object sender, EventArgs e)
        {
            //Initialisieren eines neuen Threads
            Thread my_thread = new Thread(Berechne);
            //Name setzen
            my_thread.Name = "T1";
            //Thread starten
            my_thread.Start(15);
     

            Thread my_thread1 = new Thread(Berechne);
            //Name setzen
            my_thread1.Name = "T2";
            //Thread starten
            my_thread1.Start(15);
        }

        //Eigentliche Methode, die der Thread ausführt
        private void Berechne(object anzahl)
        {
            for (int i = 0; i < (int)anzahl; i++)
            {
                //Thread.Sleep(20);
                
                Debug.Print ("Thread arbeitet " + Thread.CurrentThread.Name +" "+ i+"  ");
                //In Textbox ausgeben --> so nicht
                //textBox1.Text = "" + i;
                //SystemSounds.Beep.Play();
            }
            Debug.Print("Thread ist am Ende");
        }
    }
}