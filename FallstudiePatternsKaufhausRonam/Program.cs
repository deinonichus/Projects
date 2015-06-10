using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallstudiePatternsKaufhausRonam {
    class Program {
        static void Main(string[] args) {
            Mediator genericMediator = new Mediator("generic");

            Panel getränke = new Panel("getränke", genericMediator);
            Panel esswaren = new Panel("esswaren", genericMediator);
            Panel spielwaren = new Panel("spielwaren", genericMediator);

            genericMediator.addPanel(getränke);
            genericMediator.addPanel(esswaren);
            genericMediator.addPanel(spielwaren);

            genericMediator.displayMessage("neue Aktionen", getränke);

            Console.ReadKey();
        }

        class Mediator {
            string mediatorName;
            List<Panel> panelList = new List<Panel>();

            public Mediator(string mediatorName) {
                this.mediatorName = mediatorName;
            }

            public void addPanel(Panel panel) {
                panelList.Add(panel);
            }

            public void broadcastMessage(string message, Panel senderPanel) {
                foreach (Panel panel in panelList) {
                    if (senderPanel.getName() != panel.getName()) {
                        Console.WriteLine("Sender: " + panel.getName() + ":\t" + panel.displayMessage());
                    }
                }
            }

            public void displayMessage(string message, Panel targetPanel) {
                Console.WriteLine("Panel " + targetPanel.getName() + ":\t\"" + targetPanel.displayMessage() + "\"");
            }
        }

        class Panel {
            string panelName;

            List<Message> messageQueue = new List<Message>();

            public Panel(string panelName, Mediator mediator) {
                this.panelName = panelName;
            }

            public string displayMessage() {
                string messages = "";
                foreach (Message message in messageQueue) {
                    messages += message.getMessage();
                }
                return messages;
            }

            public string getName() {
                return panelName;
            }

            public void addMessage(Message message) {
                messageQueue.Add(message);
            }

            public void removeMessage(Message message) {
                messageQueue.Remove(message);
            }
        }

        class Message {
            string message;
            string title;
            bool visible = false;

            public Message(string message, string title) {
                this.message = message;
                this.title = title;
            }

            public void setMessage(string message) {
                this.message = message;
            }

            public string getMessage() {
                return message;
            }

            public void disableMessage() {
                visible = false;
            }

            public bool isVisible() {
                return visible;
            }
        }
    }
}
