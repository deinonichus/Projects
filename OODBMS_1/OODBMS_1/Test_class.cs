

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OODBMS_1
{
    class Test_class
    {

        //Eigenschaften
        string name;

        //Methoden

        //Konstruktor
        public Test_class(string t_name)
        {
            name = t_name;
        }

        //Ausgeben des Namens
        public string gib_name()
        {
            return name;
        }

        //Namen ändern
        public void aendere_namen(string t_newname)
        {
            name = t_newname;
        }
    }
}
