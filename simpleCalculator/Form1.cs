using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculator {
    delegate double calculate(double x, double y);
    public partial class Form1 : Form {
        calculate myDelegate;
        public Form1() {
            InitializeComponent();
        }

        public double addieren(double x, double y) {
            return x + y;
        }
        public double multiplizieren(double x, double y) {
            return x * y;
        }
        public double subtrahieren(double x, double y) {
            return x - y;
        }
        public double dividieren(double x, double y) {
            return x / y;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void buttonCalculate_Click(object sender, EventArgs e) {
            // method which uses
            // instanzieren

            double digitOne = 0;
            double digitTwo = 0;
            double result;

            try {
                digitOne = Convert.ToDouble(textBoxNumberOne.Text.ToString());
                digitTwo = Convert.ToDouble(textBoxNumberTwo.Text.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (radioButtonAddieren.Checked == true) {
                // Assign methodpointer to method
                myDelegate = addieren;
            }
            else if (radioButtonMultiplizieren.Checked == true) {
                myDelegate = multiplizieren;
            }
            else if (radioButtonSubtrahieren.Checked == true) {
                myDelegate = subtrahieren;
            }
            else {
                MessageBox.Show("Wählen Sie eine Rechenoperation aus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            result = myDelegate(digitOne, digitTwo);
            textBoxResult.Text = result.ToString();
        }
    }
}
