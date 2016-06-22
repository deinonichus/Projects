using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Zusätzliche Namespaces
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Discovery;

namespace WCF_Dynamic_Server
{
    [ServiceContract]
    public interface ICustomers
    {
        [OperationContract]
        string Get_kunde(string value);
    }

    [ServiceContract]
    public interface IEmployees
    {
        [OperationContract]
        string Get_arbeiter(string value);
    }

    class Customers:ICustomers
    {
        public string Get_kunde(string value)
        {
            return string.Format("Kunden aufgeweckt by {0}", value);
        }
    }

    class Employees:IEmployees
    {
        public string Get_arbeiter(string value)
        {
            return string.Format("Kunden aufgeweckt by {0}", value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ServiceHostEmployees = new ServiceHost(typeof(Employees));
            ServiceHostEmployees.Open();
            ServiceHostEmployees.Description.Endpoints.ToList().ForEach
                (x=> Console.WriteLine("Arbeiter gehosted: "+x.Address));

            var ServiceHostCustomers = new ServiceHost(typeof(Customers));
            ServiceHostCustomers.Open();
            ServiceHostCustomers.Description.Endpoints.ToList().ForEach
                (x => Console.WriteLine("Kunden gehosted: " + x.Address));

            Console.ReadLine();
        }
    }
}
