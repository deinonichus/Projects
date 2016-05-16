using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetautomat.Control
{
    class PriceController
    {
        Model.Preistabelle PT;
        static object locker;

        public PriceController()
        {
            PT = new Model.Preistabelle();
            locker = new object();
        
        }

        public void getPrice(bool tHalbtax, bool tRetour, string tOrt, Form1 tForm1)
        {

            int grundpreis;

            if (tOrt == "Zuerich")
            {
                grundpreis = 12;
            }

            else if (tOrt == "Airolo")
            {
                grundpreis = 6;
            }

            else if (tOrt != "Zuerich" && tOrt != "Airolo")
            {
                grundpreis = 16;
            }

            else
            {
                grundpreis = 200;
            }


            lock(locker)
            {
                if (tHalbtax)
                {
                    grundpreis = grundpreis / 2;
                }

                if (tRetour)
                {
                    grundpreis = grundpreis * 2;
                }

                tForm1.preisAnzeigenFromAnotherThread(grundpreis);
                tForm1.fahrpreis = grundpreis;
            }
        }

        public void muenzEinwurf(int tGeldeinwurf, Form1 tForm1)
        {
            lock(locker)
            {
                tForm1.guthaben += tGeldeinwurf;
                tForm1.guthabenanzeigenFromAnotherThread(tForm1.guthaben);
            }
        }

        public void rueckgeldBerechnen(Form1 tForm1)
        {
            int rueckgeld = tForm1.guthaben - tForm1.fahrpreis;

            lock(locker)
            {
                if (rueckgeld == 0)
                {
                    tForm1.fillTextBoxFromAnotherThread("Sie kriegen einen Scheiss zurück.");
                    adjustGuthaben((rueckgeld), tForm1);
                }

                if (tForm1.guthaben - tForm1.fahrpreis > 0)
                {
                    tForm1.fillTextBoxFromAnotherThread("Hier haben Sie Ihre " + (rueckgeld) + " zurück.");
                    adjustGuthaben((rueckgeld), tForm1);
                }
            }
        }

        private void adjustGuthaben(int tRestguthaben, Form1 tForm1)
        {
            lock (locker)
            {
                tForm1.guthabenanzeigenFromAnotherThread(tRestguthaben);
                tForm1.guthaben = tRestguthaben;
            }            
        }

        public void kaufen(Form1 tForm1)
        {
            if (tForm1.guthaben >= tForm1.fahrpreis)
            {
                rueckgeldBerechnen(tForm1);
            }

            else
            {
                tForm1.fillTextBoxFromAnotherThread("Fehlt da nicht noch ein wenig Geld???");
            }
        }

        public void reset(Form1 tForm1)
        {
            lock (locker)
            {
                tForm1.fahrpreis = 0;
                tForm1.guthaben = 0;
                tForm1.halbtax = false;
                tForm1.zurueck = false;
            }
        }
    }
}
