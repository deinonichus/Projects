using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Zubinden des Servicemodels
using System.ServiceModel;


namespace WCFExample
{
    //Region, welche als SystemContract definiert îst
    [ServiceContract]
    public interface ICalculate 
    {
        [OperationContract] 
        double Multiply(double A, double B);

        [OperationContract]
        double Addition(double A, double B);
    }

    //Benutzbare Klasse, welche den ServiceContract erbt
    public class Calculate : ICalculate
    { 
        public double Multiply(double A, double B) 
        { return A * B; }

        public double Addition(double A, double B)
        { return A + B; }
    }

    class Program
    {//Definition des Servers
        static void Main(string[] args)
        {
            //Definition des Servicehost --> mit Klasse Calculate verbunden
            ServiceHost calcService = new ServiceHost(typeof(Calculate));

            //try
            //{ //Physisches Öffnen
                calcService.Open();
                Console.WriteLine("Service is up and running… Press return to terminate.");
                //verhindert das Schliessen des Servicehost  
                Console.ReadLine();
           // }
           // catch (Exception ex)
            //{
               // Console.WriteLine(ex.Message);
                //Console.ReadKey();
            //}
            //finally
            //{
                calcService.Close();
            //}
        }
    }
}
