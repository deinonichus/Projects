using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Philosophers {
    class Program {
        public static List<Fork> Chuchichästli = new List<Fork>();
        static object Locker = new object();
        static Mutex Mutex = new Mutex();
        static void Main(string[] args) {
            // Initialisierung
            Philosopher Aristoteles = new Philosopher("Aristoteles");
            Philosopher Schopenhauer = new Philosopher("Schopenhauer");
            Philosopher Kant = new Philosopher("Kant");
            Philosopher Kramer = new Philosopher("Kramer");
            Philosopher Hegel = new Philosopher("Hegel");

            Fork Fork_0 = new Fork(0);
            Fork Fork_1 = new Fork(1);
            Fork Fork_2 = new Fork(2);
            Fork Fork_3 = new Fork(3);
            Fork Fork_4 = new Fork(4);

            Chuchichästli.Add(Fork_0);
            Chuchichästli.Add(Fork_1);
            Chuchichästli.Add(Fork_2);
            Chuchichästli.Add(Fork_3);
            Chuchichästli.Add(Fork_4);

            //Thread Thread = new Thread(Philosoph_StatusNetz);
            //Thread Thread = new Thread(new ParameterizedThreadStart(Philosoph_StatusNetz));
            //Thread.Start(Aristoteles);

        }

        static public void Philosoph_StatusNetz(Philosopher Philosopher) {
            while (Philosopher.State != 3) {
                if (Philosopher.State == 0) {
                    takeFork(Philosopher);
                }
                else if (Philosopher.State == 2) {
                    giveFork(Philosopher);
                }
            }
        }

        static public Philosopher takeFork(Philosopher Philosopher) {
            lock (Locker) {
                try {
                    Fork Fork = Chuchichästli.First();
                    Philosopher.Forks.Add(Fork);
                    Chuchichästli.Remove(Fork);

                    Fork = Chuchichästli.First();
                    Philosopher.Forks.Add(Fork);
                    Chuchichästli.Remove(Fork);

                    Philosopher.State = 1;
                    return Philosopher;
                }
                catch {
                    return Philosopher;
                }
            }
        }

        static public Philosopher giveFork(Philosopher Philosopher) {
            lock (Locker) {
                try {
                    Fork Fork = Philosopher.Forks.First();
                    Philosopher.Forks.Remove(Fork);
                    Chuchichästli.Add(Fork);

                    Fork = Philosopher.Forks.First();
                    Chuchichästli.Add(Fork);
                    Philosopher.Forks.Remove(Fork);
                    return Philosopher;
                }
                catch {
                    return Philosopher;
                }
            }
        }
    }
}
