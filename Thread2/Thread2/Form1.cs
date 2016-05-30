using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Zusätzliche Namespaces
using System.Threading;

namespace Thread2
{

    public partial class Form1 : Form
    {
        //delegate -> Programmierwurmloch
        public delegate void MyAnzeigeDelegate(string msg);

        //Klassenglobalen Eigenschaften
        int summe = 0;
        int id = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //Eigentliche Zugriffsmethode auf die Listbox
        public void myAnzeige(string msg)
        {
            listBox1.Items.Add(msg);
        }

        //CallBackFunktion
        public void BerechneMitAnzeige(object anzahl)
        {
            //Simple Lockvariable
            //Start kritischer Abschnitt
            lock (this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    summe++;
                    string s = "Thread: " + Thread.CurrentThread.Name  + " :Summe= " + summe.ToString();
                    //Zugriff auf ListBox via Delegate
                    //listBox1.Items.Add("Hallo");
                    listBox1.Invoke(new MyAnzeigeDelegate(myAnzeige), new object[] { s });
                }
            }
            //Ende kritischer Abschnitt
        }

        //Hauptmethode
        private void button1_Click(object sender, EventArgs e)
        {
            //Thread erzeugen
            Thread t1 = new Thread(BerechneMitAnzeige);
            t1.Name = "A";
           
            //Starten des Thread
            t1.Start();


            //Thread erzeugen
            Thread t2 = new Thread(BerechneMitAnzeige);
            t2.Name = "B";

            //Starten des Thread
            t2.Start();
        }
    }
}