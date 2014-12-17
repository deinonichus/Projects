
 /* Titel:   Handling Datenbankzufriff ohne Architektur
 * Autor:   C. Herren
 * Date:    11.01.2013
 * Version: 1.0
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

 //Zusätzlicher Namespace
using System.Data.SqlClient;

//using System.Data.OleDb;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace My_datenzugriff_ohne_architektur
{
    public partial class Form1 : Form
    {
        static string dataSource = "local";
        static string database = "TestDB";
        static string username = "SA";
        static string password = "Aare2013";
        static string myTable = "Gruppe";
        static string myColumn = "Name";
        static string myInput = "gruppe3";


        //Connection string
        //--> Access --> static string conn_str = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\TEMP\\Zugriff_c#.mdb";

        //string conn_str = "Data Source = (local); Initial Catalog = TestDB; Uid=SA; Pwd=Aare2013;"; 
        string connectionString = "Data Source = (" + dataSource + "); Initial Catalog = " + database + "; Uid=" + username + "; Pwd=" + password + ";"; 
        
        //Dataset definieren
        DataSet myDataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        //Methode zur Demonstration des DB-Zugriffes
        private void button1_Click(object sender, EventArgs e)
        {
            //Oledb connection objekt
            SqlConnection my_conn = new SqlConnection(connectionString);

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

        //-- SELECT
        private void button2_Click(object sender, EventArgs e)
        {
            //Oledb connection objekt
            SqlConnection myConnection = new SqlConnection(connectionString);

            //Versuchen auf die DB zuzugreifen
            try
            {
                //Erfolgreich
                //Zugriff physisch
                myConnection.Open();

                //Zusätzlicher Code

                //dataadaptor füllen
                SqlDataAdapter myDataAdapter = new SqlDataAdapter("SELECT * FROM " + myTable, myConnection);
                //dataset füllen
                myDataAdapter.Fill(myDataSet, "mein_ds");

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
                myConnection.Close();
            }

        }

        //-- SELECT
        private void button3_Click(object sender, EventArgs e)
        {
            //Nutzen des DataSets
            //Umwandeln in DataTable
            DataTable myDataTable = myDataSet.Tables["mein_ds"];

            //Auslesen der DataTable
            textBox1.Text = "";
            foreach (DataRow myDataRow in myDataTable.Rows)
            {
                //Auslesen des Feldes Inhalt aus der DB
                textBox1.Text += myDataRow[myColumn]+System.Environment.NewLine;
            }

        }

        //-- INSERT
        private void button4_Click(object sender, EventArgs e)
        {
            //Connection aufbauen
            SqlConnection my_conn = new SqlConnection(connectionString);

            //Befehlsstring
            string my_sql = "INSERT INTO " + myTable +  "(" + myColumn + ") VALUES ('" + myInput + "')";

            //Commandobjekt bilden
            SqlCommand my_cmd = new SqlCommand(my_sql, my_conn);
           
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

        //-- DELETE
        private void button5_Click(object sender, EventArgs e) {
            //Connection aufbauen
            SqlConnection my_conn = new SqlConnection(connectionString);

            //Befehlsstring
            string mySQL = "DELETE FROM " + myTable + " WHERE " + myColumn + "='" + myInput + "'";

            //Commandobjekt bilden
            SqlCommand my_cmd = new SqlCommand(mySQL, my_conn);

            try {
                //Connection öffnen
                my_conn.Open();

                //Befehl abschicken
                my_cmd.ExecuteNonQuery();

            }
            catch (Exception ex) {
                //Fehlermeldung
                MessageBox.Show(ex.Message);

            }
            finally {
                //DB-Connection schliessen
                my_conn.Close();
            }
        }

    }
}