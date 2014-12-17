
 /* Titel:   Handling Datenbankzufriff ohne Architektur
 * Autor:   C. Herren
 * Date:    11.01.2010
 * Version: 1.0
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace My_datenzugriff_ohne_architektur
{
    public partial class Form1 : Form
    {
        //Connection string
        static string conn_str = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\TEMP\\Zugriff_c#.mdb";

        //dataset definieren
        DataSet my_ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        //Methode zur Demonstration des DB-Zugriffes
        private void button1_Click(object sender, EventArgs e)
        {
            //Connection string
            string conn_str = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\TEMP\\Zugriff_c#.mdb";

            //Oledb connection objekt
            OleDbConnection my_conn = new OleDbConnection(conn_str);

            //Versuchen auf die DB zuzugreifen
            try
            {
                //Erfolgreich
                //Zugriff physisch
                my_conn.Open();

                //Erfolgsmeldung
                MessageBox.Show("Alles klar");
            }
            catch (Exception ex)
            {
                //Nicht erfolgreich
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Schliessen
                my_conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Oledb connection objekt
            OleDbConnection my_conn = new OleDbConnection(conn_str);

            //Versuchen auf die DB zuzugreifen
            try
            {
                //Erfolgreich
                //Zugriff physisch
                my_conn.Open();

                //Zusätzlicher Code

                //dataadaptor füllen
                OleDbDataAdapter my_da = new OleDbDataAdapter("SELECT * FROM my_table", my_conn);
                //dataset füllen
                my_da.Fill(my_ds, "mein_ds");

                //Erfolgsmeldung
                MessageBox.Show("Alles klar");
            }
            catch (Exception ex)
            {
                //Nicht erfolgreich
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Schliessen
                my_conn.Close();
            }

        }

        //Methode zum Anzeigen
        private void button3_Click(object sender, EventArgs e)
        {
            //Nutzen des DataSets
            //Umwandeln in DataTable
            DataTable my_dt = my_ds.Tables["mein_ds"];

            //Auslesen der DataTable
            foreach (DataRow my_dr in my_dt.Rows)
            {
                //Auslesen des Feldes Inhalt aus der DB
                textBox1.Text += my_dr["Inhalt"]+"<br>";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Connection aufbauen
            OleDbConnection my_conn = new OleDbConnection(conn_str);

            
            //Befehlsstring
            string my_sql = "INSERT INTO my_table (Inhalt) VALUES ('vier')";

            //Commandobjekt bilden
            OleDbCommand my_cmd = new OleDbCommand(my_sql, my_conn);
           
            try
            {
                //Connection öffnen
                my_conn.Open();

                //Befehl abschicken
                my_cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Fehlermeldung
                MessageBox.Show(ex.Message);

            }
            finally
            {
                //DB-Connection schliessen
                my_conn.Close();
            }
        }
    }
}