using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Zusätzliche Namespaces
using System.IO;
using Db4objects.Db4o;
using Db4objects.Db4o.Query;


namespace OODBMS_1
{
    public partial class Form1 : Form
    {
        //Definition des Datenfiles
        static string YapFileName = "C:\\Temp\\test.yap";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Methoden zum Handling der Datenbank
        public void oeffne_datenbank()
        {
            try
            {
                using (IObjectContainer db = Db4oEmbedded.OpenFile(YapFileName))
                {
                    // do something with db4o
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //oeffnen_datenbank
            oeffne_datenbank();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //erzeugen testobjekte
            Test_class my_ob = new Test_class("Herren1");

            try
            {
                using (IObjectContainer db = Db4oEmbedded.OpenFile(YapFileName))
                {
                    db.Store(my_ob);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (IObjectContainer db = Db4oEmbedded.OpenFile(YapFileName))
                {
                    //Native Query
                    //leerer Prototyp für die Suche --> alle 
                    Test_class proto = new Test_class(null);
                    //Set der gefundenen Einträge schreiben
                    IObjectSet result = db.QueryByExample(proto);

                    //Ausgeben
                    foreach (object item in result)
                    {
                        //Casten in Test_class
                       Test_class my_item = (Test_class)item;
                        //Ausgeben des Names mittels Methode der Klasse
                       textBox1.Text += my_item.gib_name() + System.Environment.NewLine ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Suchen
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (IObjectContainer db = Db4oEmbedded.OpenFile(YapFileName))
                {
                    //Native Query
                    Test_class proto = new Test_class("Herren");
                    IObjectSet result = db.QueryByExample(proto);

                    //Ausgeben
                    foreach (object item in result)
                    {
                       Test_class my_item = (Test_class)item;
                       textBox1.Text += my_item.gib_name() + System.Environment.NewLine ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Update
        private void button4_Click(object sender, EventArgs e)
        {
             try
            {
                using (IObjectContainer db = Db4oEmbedded.OpenFile(YapFileName))
                {
                    //Native Query
                    IObjectSet result = db.QueryByExample(new Test_class("Herren1"));
                    //Erstes gefundenes Objekt
                    Test_class found = (Test_class)result.Next();
                    //aendern methode von db4object
                    found.aendere_namen("Gates");
                    db.Store(found);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Löschen
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (IObjectContainer db = Db4oEmbedded.OpenFile(YapFileName))
                {
                    //Native Query
                    //Suchen nach Beispiel (Maske)
                    IObjectSet result = db.QueryByExample(new Test_class("Gates"));
                    //Objekt definieren
                    Test_class found = (Test_class)result.Next();
                    //Methode löschen nutzen
                    db.Delete(found);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e) {
            try
            {
                using (IObjectContainer db = Db4oEmbedded.OpenFile(YapFileName))
                {
                    //Native Query
                    Test_class proto = new Test_class("Herren");
                    IObjectSet result = db.QueryByExample(proto);

                    //Ausgeben
                    foreach (object item in result)
                    {
                       Test_class my_item = (Test_class)item;
                       textBox1.Text += my_item.gib_name() + System.Environment.NewLine;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            var results =    
                from Person c in db    
                where c.Name.Contains(“Herren1”)    
                orderby c.Name descending    
                select c;

        }

    }
}
