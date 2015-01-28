using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2015-01-19; DSL; HF TEKO; Objektorientiertes Programmieren

namespace binaryTree {
    class Node {
        // the nodes description
        string content;
        Node left = null;
        Node right = null;

        public Node(string t_Content) {
            content = t_Content;
        }

        // method to assign nodes (could also be done in the constructor)
        public void assignLeft(Node t_Node) {
            left = t_Node;
        }
        public void assignRight(Node t_Node) {
            right = t_Node;
        }
        public string getContent() {
            return content;
        }
        public Node getLeft() {
            return left;
        }
        public Node getRight() {
            return right;
        }
    }

    class Program {
        // method for preorder
        static public void recursivePreorder(Node t_Node) {
            if (t_Node != null) {
                //print content
                Console.WriteLine("Content: " + t_Node.getContent());

                //go to left node first
                recursivePreorder(t_Node.getLeft());
                recursivePreorder(t_Node.getRight());
            }
        }

        static public void recursivePostorder(Node t_Node) {
            if (t_Node != null) {
                //go to left node first
                recursivePostorder(t_Node.getLeft());
                recursivePostorder(t_Node.getRight());

                //print content
                Console.WriteLine("Content: " + t_Node.getContent());
            }
        }

        static public void recursiveInorder(Node t_Node) {
            if (t_Node != null) {
                //go to left node first
                recursivePostorder(t_Node.getLeft());

                //print content
                Console.WriteLine("Content: " + t_Node.getContent());

                recursivePostorder(t_Node.getRight());
            }
        }

        static void Main(string[] args) {
            // generate the root of the binary tree
            Node myRoot = new Node("W");
            Node myLeft = new Node("A");
            Node myRight = new Node("B");

            // assign nodes
            myRoot.assignLeft(myLeft);
            myRoot.assignRight(myRight);
            //--> tree with 2 levels

            Node myleft00 = new Node("A1");
            Node myright00 = new Node("B1");
            myLeft.assignLeft(myleft00);
            myLeft.assignRight(myright00);
            //--> tree with 3 levels, left node on level 2 has two childs

            //iterate over tree
            Console.WriteLine("Preorder");
            recursivePreorder(myRoot);
            Console.ReadKey();

            Console.WriteLine("Postorder");
            recursivePostorder(myRoot);
            Console.ReadKey();

            Console.WriteLine("Inorder");
            recursiveInorder(myRoot);
            Console.ReadKey();
        }
    }
}
