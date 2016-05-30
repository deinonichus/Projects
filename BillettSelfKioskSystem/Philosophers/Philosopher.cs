using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philosophers {
    class Philosopher {
        public string Name { get; set; }

        /** States
         * 0    hungernd
         * 1    essend
         * 2    verdauend
         * 3    satt
         **/
        public int State { get; set; }
        public int ID { get; set; }
        public List<Fork> Forks { get; set; }

        public Philosopher (string Name) {
            this.Name = Name;
            State = 0;
        }

        public bool takeFork() {

            return true;
        }

        public bool giveFork() {

            return true;
        }
    }
}
