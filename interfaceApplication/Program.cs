// 2015-04-22 DSL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceApplication {
    interface IGeometry {
        double flaeche_berechnen();
        double umfang_berechnen();
    }

    // erste geometrische Figur
    class Quadrat : IGeometry {
        //Eigene Eigenschaften
        double umfang;
        double flaeche;
        double seitenlaenge;
        string masseinheit;
        //....

        public Quadrat(double t_seitenlaenge, string t_masseinheit) {
            //Zuweisen  der Laenge
            seitenlaenge = t_seitenlaenge;
            masseinheit = t_masseinheit;
        }

        //Durch Interface definierte Methode festlegen
        public double flaeche_berechnen() {
            return seitenlaenge * seitenlaenge;
        }
        public double umfang_berechnen() {
            return 4 * seitenlaenge;
        }
        public double getSeitenlaenge() {
            return seitenlaenge;
        }
        public string getMasseinheit() {
            return masseinheit;
        }
    }

    class Kreis : IGeometry {
        double radius;
        string masseinheit;

        // Constructor
        public Kreis(double t_radius, string t_masseinheit) {
            radius = t_radius;
            masseinheit = t_masseinheit;
        }

        public double flaeche_berechnen() {
            return radius * radius * Math.PI;
        }

        public double umfang_berechnen() {
            return Math.PI * 2 * radius;
        }

        public string getMasseinheit() {
            return masseinheit;
        }
    }

    class Program {
        static void Main(string[] args) {
            // Objekt Quadrat implementieren
            Quadrat my_Quadrat = new Quadrat(4, "m");
            Kreis my_Kreis = new Kreis(4, "m");

            // Berechnen der Fläche
            Console.WriteLine("geometrische Form:\t Quadrat");
            Console.WriteLine("Fläche:\t" + my_Quadrat.flaeche_berechnen() + my_Quadrat.getMasseinheit());
            Console.WriteLine("Umfang:\t" + my_Quadrat.umfang_berechnen() + my_Quadrat.getMasseinheit());

            Console.WriteLine("geometrische Form:\t Kreis");
            Console.WriteLine("Fläche:\t" + my_Kreis.flaeche_berechnen() + my_Kreis.getMasseinheit());
            Console.WriteLine("Umfang:\t" + my_Kreis.umfang_berechnen() + my_Kreis.getMasseinheit());

            Console.ReadKey();
        }
    }
}
