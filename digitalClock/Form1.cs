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

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new System.EventHandler(showTime);
            timer.Start();
            showTime(null, null);
        }

        // possible states: none, hours, minutes, seconds
        string editState = "none";
        int hours = 0;
        int minutes = 0;
        int seconds = 0;

        private void showTime(object sender, EventArgs e) {
            DateTime now = System.DateTime.Now;
            now = now.AddHours(hours);
            now = now.AddMinutes(minutes);
            now = now.AddSeconds(seconds);
            if (now.Hour.ToString().Length < 2) {
                textBoxHours.Text = "0" + now.Hour.ToString();
            }
            else {
                textBoxHours.Text = now.Hour.ToString();
            }
            if (now.Minute.ToString().Length < 2) {
                textBoxMinutes.Text = "0" + now.Minute.ToString();
            }
            else {
                textBoxMinutes.Text = now.Minute.ToString();
            }
            if (now.Second.ToString().Length < 2) {
                textBoxSeconds.Text = "0" + now.Second.ToString();
            }
            else {
                textBoxSeconds.Text = now.Second.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            textBoxHours.Text = "0";
            textBoxMinutes.Text = "0";
            textBoxSeconds.Text = "0";
        }

        public void incrementHours(object sender, EventArgs e) {
            if (hours >= 23) {
                hours = 0;
            }
            else {
                hours++;
            }
            showTime(sender, e);
        }
        public void incrementMinutes(object sender, EventArgs e) {
            if (minutes >= 59) {
                minutes = 0;
                incrementHours(sender, e);
            }
            else {
                minutes++;
            }
            showTime(sender, e);
        }
        public void incrementSeconds(object sender, EventArgs e) {
            if (seconds >= 59) {
                seconds = 0;
                incrementMinutes(sender, e);
            }
            else {
                seconds++;
            }
            showTime(sender, e);
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
