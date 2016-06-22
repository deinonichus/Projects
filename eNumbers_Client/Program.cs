using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Collections;

namespace eNumbers_Client {
    
    [ServiceContract]
    public interface IGetIngredients {
        public static Hashtable Ingredients = new Hashtable();
        [OperationContract]
        Hashtable getIngredient(int eNumber);
    }
    class Program {
        static void Main(string[] args) {
            ChannelFactory<IGetIngredients> factory = new ChannelFactory<IGetIngredients>( new WSHttpBinding(), new EndpointAddress("http://localhost:2311/GetIngredients"));
            IGetIngredients channel = factory.CreateChannel();

            // Hier erfolgt der Aufruf der Methode Multiply
            // Der Rückgabewert wird in die Variable result gespeichert 
            Hashtable ingredients = channel.getIngredient(2);
            Console.WriteLine(String.Format("Result: {0}", ingredients));

            //Warten
            Console.ReadLine();
        }
    }
}
