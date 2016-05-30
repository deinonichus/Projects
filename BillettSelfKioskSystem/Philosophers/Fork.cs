using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philosophers {
    class Fork {
        public string Name { get; set; }
        public int ID { get; set; }


        public Fork(int ID) {
            this.ID = ID;
        }
    }
}
