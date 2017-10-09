using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Threading;

namespace ConsoleApplication1
{
    public static class Sender
    {
        public static object JsonHelpers { get; private set; }

        public static void SendRequests()
        {
            //string api1 = "http://localhost:9191/view-service/views/9/parent/1004";
            //string api2 = "http://localhost:9191/view-service/views/1008/parent/1004";
            //string api3 = "http://localhost:9191/view-service/views/1009/parent/1004";
            //string api4 = "http://localhost:9191/view-service/views/1010/parent/1004";
                      

            //var result1 = await client.PostAsync(api1, new StringContent(JsonConvert.SerializeObject(values)));
            //var result2 = await client.PostAsync(api2, new StringContent(JsonConvert.SerializeObject(values)));
            //var result3 = await client.PostAsync(api3, new StringContent(JsonConvert.SerializeObject(values)));
            //var result4 = await client.PostAsync(api4, new StringContent(JsonConvert.SerializeObject(values)));
            
            Thread thread1 = new Thread(SenRequest1);
            Thread thread2 = new Thread(SenRequest2);
            Thread thread3 = new Thread(SenRequest3);

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private static async void SenRequest1()
        {
            string api = "http://192.168.50.23:9191/view-service/views/9/parent/1004";
            Console.WriteLine("Start " + DateTime.Now); var values = new NameValueCollection();
            values["position"] = "1";
            StringContent content = new StringContent(JsonConvert.SerializeObject(values));
            HttpClient client = new HttpClient();
            var result = await client.PostAsync(api, content);

            Console.WriteLine(result.StatusCode);
        }

        private static async void SenRequest2()
        {
            string api = "http://localhost:9191/view-service/views/1008/parent/1004";
            Console.WriteLine("Start " + DateTime.Now); var values = new NameValueCollection();
            values["position"] = "1";
            StringContent content = new StringContent(JsonConvert.SerializeObject(values));
            HttpClient client = new HttpClient();
            var result = await client.PostAsync(api, content);

            Console.WriteLine(result.StatusCode);
        }

        private static async void SenRequest3()
        {
            string api = "http://192.168.50.23:9191/view-service/views/1009/parent/104";
            Console.WriteLine("Start " + DateTime.Now); var values = new NameValueCollection();
            values["position"] = "1";
            StringContent content = new StringContent(JsonConvert.SerializeObject(values));
            HttpClient client = new HttpClient();
            var result = await client.PostAsync(api, content);

            Console.WriteLine(result.StatusCode);
        }
    }
}
