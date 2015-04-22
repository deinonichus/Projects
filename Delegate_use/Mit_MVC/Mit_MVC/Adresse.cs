using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mit_MVC
{
    [Serializable]
    class Adresse
    {
        //Eigenschaften
        string Name;
        string Vorname;

        //Konstruktor
        public Adresse(string t_Name, string t_Vorname)
        {
            Name = t_Name;
            Vorname = t_Vorname;
        }

        //Methoden 

        //Name ausgeben
        public string gib_name()
        {
            return Name;
        }

        //Vorname ausgeben
        public string gib_vorname()
        {
            return Vorname;
        }

    }
}
