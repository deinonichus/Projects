using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Collections;

namespace eNumbers {
    [ServiceContract]
    public interface IGetIngredients {
        [OperationContract]
        Hashtable getIngredient(int eNumber);
    }

    public class GetIngredients : IGetIngredients {
        public static Hashtable Ingredients = new Hashtable();
        //public Hashtable Ingredients { get; set; }
        public Hashtable getIngredient(int eNumber) {
            return Ingredients;
        }
    }

    class Program {
        static void Main(string[] args) {
            ServiceHost BAGservice = new ServiceHost(typeof(GetIngredients));
            BAGservice.Open();
            
            Console.WriteLine("Service is up and running… Press return to terminate.");

            Console.ReadLine();
            BAGservice.Close();
        }
    }
}
