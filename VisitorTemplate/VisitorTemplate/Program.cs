using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTemplate {
    interface ICarElementVisitor {
        void visit(Wheel wheel);
        void visit(Engine engine);
        void visit(Body body);
        void visit(Car car);
    }
 
    interface ICarElement {
        void accept(ICarElementVisitor visitor); // CarElements have to provide accept().
    }
 
    class Wheel : ICarElement {
        private String name;
 
        public Wheel(String name) {
            this.name = name;
        }
 
        public String getName() {
            return this.name;
        }
 
        public void accept(ICarElementVisitor visitor) {
            /*
             * accept(ICarElementVisitor) in Wheel :
             * accept(ICarElementVisitor) in ICarElement, so the call
             * to accept is bound at run time. This can be considered
             * the first dispatch. However, the decision to call
             * visit(Wheel) (as opposed to visit(Engine) etc.) can be
             * made during compile time since 'this' is known at compile
             * time to be a Wheel. Moreover, each implementation of
             * ICarElementVisitor : the visit(Wheel), which is
             * another decision that is made at run time. This can be
             * considered the second dispatch.
             */
            visitor.visit(this);
        }
    }
 
    class Engine : ICarElement {
        public void accept(ICarElementVisitor visitor) {
            visitor.visit(this);
        }
    }
 
    class Body : ICarElement {
        public void accept(ICarElementVisitor visitor) {
            visitor.visit(this);
        }
    }
 
    class Car : ICarElement {
        ICarElement[] elements;
 
        public Car() {
            //create new Array of elements
            this.elements = new ICarElement[] { 
                new Wheel("front left"),
                new Wheel("front right"), 
                new Wheel("back left") ,
                new Wheel("back right"), 
                new Body(), 
                new Engine() 
            };
        }
 
        public void accept(ICarElementVisitor visitor) {    
            foreach(ICarElement elem in elements) {
                elem.accept(visitor);
            }
            visitor.visit(this);    
        }
    }
 
    //Visitor to print name of wisited part
    class CarElementPrintVisitor : ICarElementVisitor {

        public void visit(Wheel wheel) {
            Console.WriteLine("Visiting " + wheel.getName() + " wheel");
        }
 
        public void visit(Engine engine) {
            Console.WriteLine("Visiting engine");
        }
 
        public void visit(Body body) {
            Console.WriteLine("Visiting body");
        }
 
        public void visit(Car car) {
            Console.WriteLine("Visiting car");
        }
    }
 
    //Visitor to do some action
    class CarElementDoVisitor : ICarElementVisitor {
        public void visit(Wheel wheel) {
            Console.WriteLine("Kicking my " + wheel.getName() + " wheel");
        }
 
        public void visit(Engine engine) {
            Console.WriteLine("Starting my engine");
        }
 
        public void visit(Body body) {
            Console.WriteLine("Moving my body");
        }
 
        public void visit(Car car) {
            Console.WriteLine("Starting my car");
        }
    }
 
    
    class Program {
        static void Main(string[] args) {
            ICarElement car = new Car();

            Console.WriteLine("Start Visitor to print the parts");
            car.accept(new CarElementPrintVisitor());

            Console.WriteLine();
            Console.WriteLine("Start Visitor to do some action");
            car.accept(new CarElementDoVisitor());

            Console.ReadLine();
        }
    }
}
