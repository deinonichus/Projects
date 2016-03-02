using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Person {
        public string Surname { get; set; }
        public string Prename { get; set; }
        public string Sex { get; set; }
        public Pet Pet { get; set; }
        public string Signature() {
            return "My name is: " + Prename + " " + Surname;
        }
        public Person Slave { get; set; }
    }
}
