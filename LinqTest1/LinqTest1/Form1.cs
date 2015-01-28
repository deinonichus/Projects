
/*
 * Data Mapping mit LINQ
 * 
 * Autor:   C. Herren
 * Datum:   04.04.2011
 * Version: 1.0
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//zusätzlicher Namespace
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace LinqTest1
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string database = "RechnungenFallbeispiel";
        static string dataSource = "(local)";
        static string username = "dave";
        static string password = "";
        //static string myTable = "Gruppe";
        //static string myColumn = "Name";
        static string myContent = "gruppe3";
        //static DataContext myDataBase = new DataContext(@"Data Source=" + dataSource + "; Initial Catalog = " + database + "; Uid = " + username + "; Password = " + password);
        static DataContext myDataBase = new DataContext(@"Data Source=" + dataSource + "; Initial Catalog = " + database + "; Integrated Security = true");
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Verbindung definieren
                //DataContext myDataBase = new DataContext(@"Data Source=" + dataSource + "; Initial Catalog = " + database + "; Integrated Security = True");
                //DataContext my_db = new DataContext(@"Data Source=T4W00\SQLEXPRESS; Initial Catalog = test_2; Integrated Security = True");
                //Connect auf Tabelle inkl. dem Mapping
                Table<my_definition> my_inhalt = myDataBase.GetTable<my_definition>();

                //Auswerten der typisierten Liste
                var einträge =
                                from my_i in my_inhalt
                                select my_i;

                //Ausgabe
                foreach (var i in einträge)
                {
                    textBox1.Text += i.Name + System.Environment.NewLine; ;
                }
            }
            catch (Exception ex)
            {
                //Schief gelaufen
                MessageBox.Show(ex.Message);
            }
        }

        //Methode zum Eintragen in die Tabelle
        private void button2_Click(object sender, EventArgs e)
        {
            //Verbindung definieren
            //DataContext myDataBase = new DataContext(@"Data Source=T4W00\SQLEXPRESS; Initial Catalog = test_2; Integrated Security = True");
            //Connect auf Tabelle inkl. dem Mapping
            Table<my_definition> my_inhalt = myDataBase.GetTable<my_definition>();

            //neues Objekt erstellen
            my_definition my_schreibobjekt = new my_definition();

            //Objekt beladen
            //my_schreibobjekt.Pkey_1 = 8;
            my_schreibobjekt.Name = "gruppe3";

            //Schreiben in Tabelle
            //my_db.ExecuteCommand("SET IDENTITY_INSERT Tabelle_1 ON");
            my_inhalt.InsertOnSubmit(my_schreibobjekt);

            //Submit an DB senden
            myDataBase.SubmitChanges();
        }

        //Methode zum Aendern
        private void button3_Click(object sender, EventArgs e)
        {
           //Verbindung definieren
           //DataContext my_db = new DataContext(@"Data Source=T4W00\SQLEXPRESS; Initial Catalog = test_2; Integrated Security = True");
           //Connect auf Tabelle inkl. dem Mapping
           Table<my_definition> my_inhalt = myDataBase.GetTable<my_definition>();

           //Abfrage zur Ermittlung der zu aendernden Elemente
            var zu_update =
                            from i_u in my_inhalt
                            where i_u.Name == "eins"
                            select i_u;

            //aenderung einpflegen
            zu_update.First().Name = "fuenf";
            
            //Aenderung auf DB auslösen
            myDataBase.SubmitChanges();
        }

        //methode zum Löschen
        private void button4_Click(object sender, EventArgs e)
        {
            //Verbindung definieren
            //DataContext my_db = new DataContext(@"Data Source=T4W00\SQLEXPRESS; Initial Catalog = test_2; Integrated Security = True");
            //Connect auf Tabelle inkl. dem Mapping
            Table<my_definition> my_inhalt = myDataBase.GetTable<my_definition>();

            //Abfrage
            var zu_loeschen =
                                from d_o in my_inhalt
                                where d_o.Name == "vier"
                                select d_o;

            //Delete on submit aufrufen -> ein element löschen
            my_inhalt.DeleteOnSubmit(zu_loeschen.First());

            //Aenderung auf DB auslösen
            myDataBase.SubmitChanges();
        }
    }


    //-------------------------------------------------------

    //Mappingklasse
    //Es gilt Typenstrenge
    [Table(Name = "Gruppe")]
    public class my_definition
    {
        //Mapper auf Primary Key
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey=true)]
        public int ID
        {
            get;
            set;
        }

        //Mapper auf Feld Inhalt
        [Column]
        public string Name;
    }

}
