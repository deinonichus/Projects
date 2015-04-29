using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatApplication {
    public partial class Form1 : Form {
        public Chat chat = new Chat();
        
        public Form1() {
            InitializeComponent();

            Observer observer1 = new Observer(chat, "Hansli");
            chat.attach(observer1);
            label1.Text = "Hansli";

            Observer observer2 = new Observer(chat, "Vreneli");
            chat.attach(observer2);
            label2.Text = "Vreneli";
        }

        public class Chat {
            List<Observer> _observers = new List<Observer>();

            public void attach(Observer o) {
                _observers.Add(o);
            }
            public void detach(Observer o) {
                _observers.Remove(o);
            }

            public void notify(TextBox textBox, string message, string sender) {
                //Methode Update des Observes für alle Observer in Liste aufrufen
                foreach (Observer observer in _observers) {
                    //Aufrufen der Updatemethode
                    observer.update(textBox, message, sender);
                }
            }
        }

        public class Observer {
            string observerName;
            Chat chat;
            //Konstruktor
            public Observer(Chat chat, string observerName) {
                this.observerName = observerName;
                this.chat = chat;
            }

            //Update Methode, Methode, welche Neuigkeit verkündet
            public void update(TextBox textBox, string message, string senderName) {
                //Ausgeben
                textBox.Text += "von: " + senderName + ": " + message + " an: " + observerName + "\n";
            }
        }

        class Logger {


        }

        private void buttonSendA_Click(object sender, EventArgs e) {
            //Nutzen des Subject
            chat.notify(textBoxObserverB, textBoxSendA.Text, "Hansli");
            textBoxSendA.Text = "";
        }

        private void buttonSendB_Click(object sender, EventArgs e) {
            //Nutzen des Subject
            chat.notify(textBoxObserverA, textBoxSendB.Text, "Vreneli");
            textBoxSendB.Text = "";
        }

    }
}
