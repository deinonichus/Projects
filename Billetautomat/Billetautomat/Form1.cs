using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Billetautomat
{
    public partial class Form1 : Form
    {
        Control.PriceController PC;


        public Form1()
        {
            InitializeComponent();
            PC = new Control.PriceController();
    }

        //
        public int guthaben = 0;
        public int fahrpreis = 0;

        //
        public bool halbtax = false;
        public bool zurueck = false;
        string zielort;

        //public delegate void InvokeDelegate();


        //Thread Fahrpreisberechnung
        public void TFahrpreisBerechnung()
        {
            Thread fpthread = new Thread(delegate () { PC.getPrice(halbtax, zurueck, zielort, this); });
            fpthread.Start();
        }

        //Thread Geldeinwurf
        public void TMuenzEinwurf(int tBetrag)
        {
            Thread methread = new Thread(delegate() { PC.muenzEinwurf(tBetrag, this); });
            methread.Start();
        }

        //Thread Kaufen
        public void TKaufen()
        {
            Thread kthread = new Thread(delegate () { PC.kaufen(this); });
            kthread.Start();
        }

        //Thread reset
        public void TReset()
        {
            Thread rthread = new Thread(delegate () { PC.reset(this); });
            rthread.Start();
        }

        //Methode kann aus anderen Threads angestossen werden
        public void guthabenanzeigenFromAnotherThread(int tGuthaben)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(guthabenanzeigenFromAnotherThread), new object[] { tGuthaben });
                return;
            }
            tbGuthaben.Clear();
            tbGuthaben.Text = Convert.ToString(tGuthaben);
        }

        //Methode kann aus anderen Threads angestossen werden
        public void preisAnzeigenFromAnotherThread(int tPreis)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(preisAnzeigenFromAnotherThread), new object[] { tPreis });
                return;
            }
            tbPreis.Clear();
            tbPreis.Text = Convert.ToString(tPreis);
        }

        //Methode kann aus anderen Threads angestossen werden
        public void fillTextBoxFromAnotherThread(string tMessage)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(fillTextBoxFromAnotherThread), new object[] { tMessage });
                return;
            }
            tbDisplay.Text += tMessage;
        }

        public void preisFestlegenFromAnotherThread(int tPreis)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(preisFestlegenFromAnotherThread), new object[] { tPreis });
                return;
            }
        }

        private void buttonMuenzCHF1_Click(object sender, EventArgs e)
        {
            TMuenzEinwurf(1);
        }

        private void buttonMuenzCHF2_Click(object sender, EventArgs e)
        {
            TMuenzEinwurf(2);
        }

        private void buttonMuenzCHF5_Click(object sender, EventArgs e)
        {
            TMuenzEinwurf(5);
        }


        private void buttonAirolo_Click(object sender, EventArgs e)
        {
            zielort = "Airolo";
            TFahrpreisBerechnung();
        }

        private void buttonZueri_Click(object sender, EventArgs e)
        {
            zielort = "Zuerich";
            TFahrpreisBerechnung();
        }

        private void buttonWallisellen_Click(object sender, EventArgs e)
        {
            zielort = "Wallisellen";
            TFahrpreisBerechnung();
        }

        private void cbHalbtax_CheckedChanged(object sender, EventArgs e)
        {
            halbtax = cbHalbtax.Checked;
            if (zielort != null)
            {
                TFahrpreisBerechnung();
            }
        }

        private void cbZurueck_CheckedChanged(object sender, EventArgs e)
        {
            zurueck = cbZurueck.Checked;
            if (zielort != null)
            {
                TFahrpreisBerechnung();
            }
        }

        private void buttonKaufen_Click(object sender, EventArgs e)
        {
            TKaufen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cbHalbtax.Checked = false;
            cbZurueck.Checked = false;
            tbCHF.Text = null;
            tbDisplay.Text = "";
            tbGuthaben.Text = "";
            tbPreis.Text = "";
        }
    }
}
