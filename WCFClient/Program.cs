using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCFClient
{
    [ServiceContract]
    public interface ICalculate 
    { 
        [OperationContract] 
        double Multiply(double A, double B);

        [OperationContract] 
        //[OperationContract]
        double Addition(double A, double B);
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<ICalculate> factory = new ChannelFactory<ICalculate>( new WSHttpBinding(), new EndpointAddress("http://localhost:2310/Calculate"));
            ICalculate channel = factory.CreateChannel();

            // Hier erfolgt der Aufruf der Methode Multiply
            // Der Rückgabewert wird in die Variable result gespeichert 
            double result = channel.Addition(2, 3); 
            Console.WriteLine(String.Format("Result: {0}", result));

            //Warten
            Console.ReadLine();
        }
    }
}
