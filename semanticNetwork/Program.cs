// Author: David Lutz
// Date: 27.05.2015
// TEKO Tin13a
// Fallstudie Semantisches Netz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanticNetwork {
    // relation between two nodes is stored in the child node.
    // possible relations are:
        // - ist
        // - ist nicht
        // - hat
        // - hat nicht
    class Node {
        string content = "";
        List<Node> childNodes = new List<Node>();
        string relation = "";
        bool rootNode = false;

        // Constructors
        public Node(string content) {
            this.content = content;
        }
        public Node(string content, string relation) {
            this.content = content;
            this.relation = relation;
        }

        // getters
        public bool isRootNode() {
            return rootNode;
        }
        public string getContent() {
            return content;
        }
        public string getRelation() {
            return relation;
        }
        public List<Node> getChildren() {
            return childNodes;
        }

        // setters
        public void setRoot() {
            rootNode = true;
        }
        public void setContent(string content) {
            this.content = content;
        }
        public void setRelation(string relation) {
            this.relation = relation;
        }
        public void addNewChild(string content, string relation) {
            childNodes.Add(new Node(content, relation));
        }
        public void addChild(Node node) {
            childNodes.Add(node);
        }
    }

    class Program {
        static public void searchPreorder(Node Node, int level) {
            string tabs = new String('\t', level);
            if (Node != null) {
                if (Node.isRootNode()) {
                    //print content
                    Console.WriteLine(Node.getContent());
                }

                //get childs
                if (Node.getChildren() != null && Node.getChildren().Count != 0) {
                    foreach (Node node in Node.getChildren()) {
                        Console.WriteLine(tabs + "\t"  + node.getRelation() + " " + node.getContent());
                        searchPreorder(node, level + 1);
                    }
                }
            }
        }

        static void Main(string[] args) {
            // create Nodes
            Node Projektmanagement = new Node("Projektmanagement");
            Node Projektleiter = new Node("Projektleiter", "hat");
            Node Mitarbeiter = new Node("Mitarbeiter", "hat");
            Node komplex = new Node("komplex", "ist");
            Node Anspruchsniveau = new Node("Anspruchsniveau", "hat");
            Node Methoden = new Node("Methoden", "hat");
            Node Planung = new Node("Planung", "ist");
            Node Controlling = new Node("Controlling", "ist");
            Node Risikomanagement = new Node("Risikomanagement", "ist");
            Node FMEA = new Node("FMEA", "ist nicht");
            Node Standardaufgabe = new Node("Standardaufgabe", "ist nicht");
            Node Sacharbeiter = new Node("Sacharbeiter", "hat");
            Node Lenkungsausschuss = new Node("Lenkungsausschuss", "hat nicht");
            Node Geschäftsleitung = new Node("Geschäftsleitung", "ist");

            // link Nodes
            Projektmanagement.addChild(Projektleiter);
            Projektmanagement.addChild(Mitarbeiter);
            Projektmanagement.addChild(komplex);
            komplex.addChild(Anspruchsniveau);
            Projektmanagement.addChild(Methoden);
            Methoden.addChild(Planung);
            Methoden.addChild(Controlling);
            Methoden.addChild(Risikomanagement);
            Methoden.addChild(FMEA);
            Projektmanagement.addChild(Standardaufgabe);
            Standardaufgabe.addChild(Sacharbeiter);
            Projektmanagement.addChild(Lenkungsausschuss);
            Lenkungsausschuss.addChild(Geschäftsleitung);

            Projektmanagement.setRoot();
            searchPreorder(Projektmanagement, 0);
            Console.ReadKey();
        }
    }
}
