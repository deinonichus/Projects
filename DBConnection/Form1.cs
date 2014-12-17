using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnection {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

        }

        DBconnector dbConnector = new DBconnector();



        private void buttonConnect_Click(object sender, EventArgs e) {
            //System.Windows.Forms.MessageBox.Show("");
        }
    }
}
