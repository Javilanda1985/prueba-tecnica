
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            api();
            Console.ReadKey();
        }

        static async void api()
        {
            var url = "https://rickandmortyapi.com/api/character";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            Console.WriteLine("**********************************");
            Console.WriteLine("\n-----------   API   -----------");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(content);

                Console.WriteLine("");
                int i = 0;
                foreach (var item in myDeserializedClass.results)
                {
                    Console.WriteLine(myDeserializedClass.results[i].name);
                    i++;
                }
                Console.WriteLine("");

            }
        }




        public class Info
        {
            public int count { get; set; }
            public int pages { get; set; }
            public string next { get; set; }
            public object prev { get; set; }
        }

        public class Location
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Origin
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Result
        {
            public int id { get; set; }
            public string name { get; set; }
            public string status { get; set; }
            public string species { get; set; }
            public string type { get; set; }
            public string gender { get; set; }
            public Origin origin { get; set; }
            public Location location { get; set; }
            public string image { get; set; }
            public List<string> episode { get; set; }
            public string url { get; set; }
            public DateTime created { get; set; }
        }

        public class Root
        {
            public Info info { get; set; }
            public List<Result> results { get; set; }
        }

    }
}
