using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Mit_MVC
{
    class Control
    {
        //Instanz des Models
        Model my_model = new Model();

        //Methode zur Entgegennahme der Daten aus der View
        public void nehme_daten_entgegen(string t_name, string t_vorname)
        {
            //Hier den Jordi-Filter einbauen

            //Umspeichern in Adress-Objekt
            Adresse my_sp_adresse= new Adresse(t_name,t_vorname);

            //Speichern der Daten
            my_model.schreibe_SF(my_sp_adresse);
        }

        //Methode zur Anforderung von Daten
        //Wie man es tun sollte
        public TextBox  hole_daten_name(TextBox t_textbox)
        {
            //Adresse als Zwischenspeicher
            Adresse my_adr = my_model.lese_SF();
            //Umsetzen in Textbox
            t_textbox.Text  = my_adr.gib_name();

            //Rückgabe der Textbox
            return t_textbox;
        }


        //Methode zur Anforderung von Daten
        //Wie man es tut
        public string hole_daten_name_real()
        {
            //Adresse als Zwischenspeicher
            Adresse my_adr = my_model.lese_SF();
          
            return "Gel: " + my_adr.gib_name();
        }


    }
}
