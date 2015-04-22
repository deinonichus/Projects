using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Zusätzlicher Namespace
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Mit_MVC
{
    class Model
    {
        //Schreiben des Objektes in ein serialisiertes File
        public void schreibe_SF(Adresse my_adr)
        {
            //Methode zum Schreiben in ein serialisiertes File
            //Erzeugen eines ByteStream
            BinaryFormatter my_bf = new BinaryFormatter();

            //Schreiben
            using (FileStream fs = new FileStream("C:\\AdressStream.bin", FileMode.Create))
            {
                //So einfach ist schreiben
                my_bf.Serialize(fs, my_adr);
            }
        }

        //Lesen des Objektes in ein serialisiertes File
        public Adresse lese_SF()
        {
            //Methode zum Lesen in ein serialisiertes File

            //Lesen
            BinaryFormatter my_bf_lesen = new BinaryFormatter();

            //Unsere neue Adresse für die gelesenen Objekte
            Adresse my_adr_lesen;

            //Lesen
            using (FileStream fs = new FileStream("C:\\AdressStream.bin", FileMode.Open))
            {
                //So einfach ist lesen
                //                                    Deserialize liefert Object zurück!!--> Casting
                my_adr_lesen = my_bf_lesen.Deserialize(fs) as Adresse;
            }

            return my_adr_lesen;
        }
    }
}
