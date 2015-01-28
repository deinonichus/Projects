using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DBConnection {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        static string dataSource = "(local)";
        static string dataBase = "RechnungenFallbeispiel";
        static DataContext myDataBase = new DataContext(@"Data Source=" + dataSource + "; Initial Catalog = " + dataBase + "; Integrated Security = true");

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void buttonConnect_Click(object sender, EventArgs e) {
            //DBconnector dbConnector = new DBconnector(databaseName, databaseUsername, databasePassword);

        }


        #region sql statements
        private void sqlSelect() {
            try {
                Table<myArtikel> contentArtikel = myDataBase.GetTable<myArtikel>();
                Table<myKunde> contentKunde = myDataBase.GetTable<myKunde>();
                Table<myRechnung> contentRechnung = myDataBase.GetTable<myRechnung>();
                Table<myRechnungsposition> contentRechnungsposition = myDataBase.GetTable<myRechnungsposition>();

                //Auswerten der typisierten Liste
                var einträge =
                                from my_i in contentArtikel
                                select my_i;

                //Ausgabe
                foreach (var i in einträge) {
                    //Form1.setTextBoxOutput(i.Name);
                }
            }
            catch (Exception ex) {
                //Schief gelaufen
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void sqlUpdate() {

        }
        private void sqlInsert() {

        }
        private void sqlDelete() {

        }
        private void sqlCreate() {

        }
        private void sqlDrop() {

        }
        #endregion

        #region mapping classes
        [Table(Name = "Artikel")]
        public class myArtikel {
            //Mapper auf Primary Key
            [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true)]
            public int ID {
                get;
                set;
            }

            //Mapper auf Feld Inhalt
            [Column]
            public string Name;
            public string mwst;
        }

        [Table(Name = "Kunde")]
        public class myKunde {
            //Mapper auf Primary Key
            [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true)]
            public int ID {
                get;
                set;
            }

            //Mapper auf Feld Inhalt
            [Column]
            public string Name;
        }

        [Table(Name = "Rechnung")]
        public class myRechnung {
            //Mapper auf Primary Key
            [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true)]
            public int ID {
                get;
                set;
            }

            //Mapper auf Feld Inhalt
            [Column]
            public string Datum;
            public int Kunde;
        }

        [Table(Name = "Rechnungposition")]
        public class myRechnungsposition {
            //Mapper auf Primary Key
            [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true)]
            public int ID {
                get;
                set;
            }

            //Mapper auf Feld Inhalt
            [Column]
            public int Menge;
            public int Rechnung;
            public int Artikel;
        }
        #endregion
    }
}
