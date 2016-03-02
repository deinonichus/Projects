using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Pet {
        public string Name { get; set; }
        public string Colour { get; set; }
        public string callPet() {
            return "I am your Pet and my name is: " + Name;
        }
    }
}
