using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Collections;

namespace eNumbers {
    class Program {
        public static Hashtable Ingredients = new Hashtable();

        [ServiceContract]
        public interface IGetIngredients {
            [OperationContract]
            string getIngredient(int eNumber);
        }

        //Benutzbare Klasse, welche den ServiceContract erbt
        public class GetIngredients : IGetIngredients {
            public Hashtable getIngredient(int eNumber) {
                return Ingredients;
            }
        }

        static void Main(string[] args) {
            ServiceHost bagService = new ServiceHost(typeof(GetIngredients));

        }
    }
}
