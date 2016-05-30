using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Zusätzliche Namespaces
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
using System.ServiceModel.Discovery;


namespace WCF_Dynamic_Client
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
    
    class Program
    {
        static void Main(string[] args)
        {
            var dynamicEndpoint = new DynamicEndpoint(ContractDescription.GetContract(typeof(IEmployees)), new WSHttpBinding(SecurityMode.None));

            //......
            var proxy = new ChannelFactory<IEmployees>(dynamicEndpoint).CreateChannel();
            var result = proxy.Get_arbeiter("hallo");

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
