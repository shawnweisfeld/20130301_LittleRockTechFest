using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FunWithJson.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rest#
            //var client = new RestClient("http://localhost:3833/");
            //var request = new RestRequest("home/customers", Method.GET);
            //var response = client.Execute<List<Customer>>(request);

            //Json.net
            var client = new WebClient();
            var response = client.DownloadString("http://localhost:3833/home/customers");
            var data = JsonConvert.DeserializeObject<List<Customer>>(response);
            dynamic data2 = JArray.Parse(response);

            foreach (dynamic customer in data2)
            {
                System.Console.WriteLine(customer.LastName);
            }



            System.Console.ReadKey();


        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
