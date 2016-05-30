
/*
 * Beispiel für 2 parallele Threads
 * Autor:   C. Herren
 * Version: 1.0
 * Datum:   25.01.2008
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Thread3
{
    class Program
    {
        //Die zu bearbeitende variable
        public static int summe = 0;

       

        //Die eigentliche Methode, die was tut
        private static void Berechne(object anzahl)
        {
            //Erzeugen Mutex
            Mutex myMutex = new Mutex();
            
            //Kritischer Abschnitt starten
            //-------------------------------------
            myMutex.WaitOne();

                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(10);
                    summe += (int)anzahl;
                    Console.WriteLine("Thread {0}: Summe= {1}", Thread.CurrentThread.Name, summe);
                }
            
            //Ende des kritischen Abschnittes
            myMutex.ReleaseMutex();
        }

        //Beispiel für mehrere Threads- unkoordiniert
        static void Main(string[] args)
        {
            //Erster Thread aufsetzen
            Thread my_t1 = new Thread(Berechne);
            my_t1.Name = "T1";

            //Zweiter Thread aufsetzen
            Thread my_t2 = new Thread(Berechne);
            my_t2.Name = "T2";

            //Threads starten
            my_t1.Start(1);
       
            my_t2.Start(1);
          
            Console.ReadLine();
        }
    }
}
