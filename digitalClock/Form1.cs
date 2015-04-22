using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digitalClock {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // possible states: none, hours, minutes, seconds
        string editState = "none";

        private void Form1_Load(object sender, EventArgs e) {
            textBoxHours.Text = "0";
            textBoxMinutes.Text = "0";
            textBoxSeconds.Text = "0";
        }

        public void incrementHours(object sender, EventArgs e) {
            int hours = Convert.ToInt32(textBoxHours.Text);
            if (hours >= 23) {
                hours = 0;
            }
            else {
                hours++;
            }
            textBoxHours.Text = hours.ToString();
        }
        public void incrementMinutes(object sender, EventArgs e) {
            int minutes = Convert.ToInt32(textBoxMinutes.Text);
            if (minutes >= 59) {
                minutes = 0;
            }
            else {
                minutes++;
            }
            textBoxMinutes.Text = minutes++.ToString();
        }
        public void incrementSeconds(object sender, EventArgs e) {
            int seconds = Convert.ToInt32(textBoxSeconds.Text);
            if (seconds >= 59) {
                seconds = 0;
            }
            else {
                seconds++;
            }
            textBoxSeconds.Text = seconds.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            
        }
        private void button2_Click(object sender, EventArgs e) {
            if (editState.Equals("none")) {
                button1.Click += new EventHandler(incrementHours);
                editState = "hours";
            }
            else if (editState.Equals("hours")) {
                button1.Click -= new EventHandler(incrementHours);
                button1.Click += new EventHandler(incrementMinutes);
                editState = "minutes";
            }
            else if (editState.Equals("minutes")) {
                button1.Click -= new EventHandler(incrementMinutes);
                button1.Click += new EventHandler(incrementSeconds);
                editState = "seconds";
            }
            else if (editState.Equals("seconds")) {
                button1.Click -= new EventHandler(incrementSeconds);
                editState = "none";
            }
        }
    }
}
