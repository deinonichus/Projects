using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace cloudservicemanagementtool {
	class MainClass {
        // Arguments (in this order)
        // - ResourceType (e.g. snapshots)
        // - ResourceID (e.g. specific drive UUID)
        // - Command (create, delete, etc)

        // Variables which should be configurable
        private static string HostAddress = "https://zrh.cloudsigma.com/";
        private static string APIversion = "api/2.0/";
        private static string ResultElementCount = "?limit=0";
        private static string MediaType = "application/json";
        private static string Username = "it-support@weblaw.ch";
        private static string Password = "cSWMbzP4";
        private static string URI;
        private static string AuthorizationString;

        // Variables which should be retrieved as arguments
        private static string ResourceType; // snapshots, drives, vms, etc (make it an enum?)
        private static string Command; // list, delete, etc (make it an enum?)
        private static string ResourceID = ""; // e.g. the specific drive to delete

        public static void Main (string[] args) {
            if (args.Length > 0) {
                ResourceType = args[0];
                try {
                    Command = args[2].ToUpper();
                    ResourceID = args[1] + "/";
                }
                catch (Exception exception) {
                    // TODO DSL: Exception handling.
                    //Console.WriteLine(exception.ToString());
                }
                URI = APIversion + ResourceType + "/" + ResourceID + "/" + ResultElementCount;
                AuthorizationString = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", Username, Password)));
                GetContentAsync(URI).Wait();
            }
            else {
                Console.WriteLine("Error: Provide the resource type as argument (e.g. snapshots).");
            }
        }

        static async Task GetContentAsync(string URI) {
            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri(HostAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaType));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", AuthorizationString);

                // GET
                HttpResponseMessage response = await client.GetAsync(URI);
                Console.WriteLine("Response Header:\n\n" + response.ToString());
                if (response.IsSuccessStatusCode) {
                    String responseString = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("\n\nResponse Content:\n\n" + responseString.ToString());
//                    string jsonString = @"{""user"":{""name"":""pre Upgrade"",""UUID"":""2143215-6943njkr-fds9532"",""status"":""available""}}";
//                    Snapshot snapshot = new Snapshot(jsonString);
//                    Console.WriteLine("Name:\t" + snapshot.Name.ToString());
//                    Console.WriteLine("UUID:\t" + snapshot.UUID.ToString());
//                    Console.WriteLine("Status:\t" + snapshot.Status.ToString());
//                    Console.WriteLine("AllocatedSize:\t" + snapshot.AllocatedSize.ToString());
//                    Console.WriteLine("ResourceURI:\t" + snapshot.ResourceURI.ToString());
//                    Console.WriteLine("Meta:\t" + snapshot.Meta.ToString());
//                    Console.WriteLine("Timestamp:\t" + snapshot.Timestamp.ToString());
                }
                else {
                    // TODO DSL: Error Handling
                }
            }
        }
	}
}
