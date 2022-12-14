using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System;
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
            fibonacci();
            Console.ReadKey();
            listaCarro();
            Console.ReadKey();
            cadenaDeTexto();
            Console.ReadKey();
            arregloDeNumeros();
            Console.ReadKey();
            api();
            Console.ReadKey();
        }

        static void fibonacci()
        {
            int[] prueba;
            int numero, a = 0, b = 1, c;
            Console.WriteLine("**********************************");
            Console.WriteLine("\n ---- Sucesion de Fibonacci ----");
            Console.Write("\nCantidad de numeros a ingresar: ");
            numero = int.Parse(Console.ReadLine());

            prueba = new int[numero];
            bool fibo = false;

            Console.WriteLine("");
            for (int i = 0; i < numero; i++)
            {
                Console.Write("Ingrese # " + (i + 1) + ": ");
                prueba[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numero; i++)
            {
                c = a + b;
                a = b;
                b = c;
                if (prueba[i] == a)
                {
                    fibo = true;
                }
                else
                {
                    fibo = false;
                    break;
                }
            }
            Console.WriteLine("\nLa sucesion de fibonacci  ingresada es: " + fibo);
            Console.WriteLine("");
        }


        static void listaCarro()
        {
            int n;
            List<Carro> listCar = new List<Carro>();

            Console.WriteLine("**********************************");
            Console.WriteLine("\n ----    Lista de Carros     ----");
            Console.Write("\nCantidad de vehiculos a agregar: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                Carro car = new Carro();
                Console.Write("Marca: ");
                car.marca = Console.ReadLine();
                Console.Write("Modelo: ");
                car.modelo = int.Parse(Console.ReadLine());
                Console.Write("Color: ");
                car.color = Console.ReadLine();
                Console.WriteLine("");
                listCar.Add(car);
            }

            IEnumerable<Carro> carModelo = from carro in listCar where carro.modelo >= 2017 select carro;
            foreach (Carro carr in carModelo)
            {
                carr.modeloCarro();
            }
        }

        class Carro
        {
            public string marca { get; set; }
            public int modelo { get; set; }
            public string color { get; set; }

            public void modeloCarro()
            {
                Console.WriteLine("Marca {0} modelo {1} color {2} ", marca, modelo, color);
            }
            public Carro()
            {
            }

            public Carro(string marca, int modelo, string color)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.color = color;
            }


        }


        static void cadenaDeTexto()
        {
            int contador = 1;
            string texto;
            bool cadena = false;

            Console.WriteLine("**********************************");
            Console.WriteLine("\n-------- Cadena de Texto --------");
            Console.Write("\n  Texto: ");
            texto = Console.ReadLine();
            Console.WriteLine("");
            foreach (char caracter in texto)
            {
                contador++;
                Console.Write(caracter);
                if (contador > 20)
                {
                    Console.Write("_");
                    cadena = true;
                    break;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("\nCadena mayor de 20 caracteres: " + cadena);
            Console.WriteLine("");
        }

        static void arregloDeNumeros()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("\n>>>  Arreglo de Numeros  <<<");
            int[] arr;
            int n, numero, contador = 0;

            Console.Write("\n   Cantidad de numeros: ");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("         Digite #: ");
                numero = int.Parse(Console.ReadLine());
                arr[i] = numero;
                if (numero % 2 == 0)
                {
                    contador++;
                }
            }
            Console.WriteLine("\n     Numeros Ingresados");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("");
            arr = arr.OrderByDescending(c => c).ToArray();
            Console.WriteLine("\n     Numeros Ordenados");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("\nCantidad de numeros pares: " + contador);
            Console.WriteLine("");
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
