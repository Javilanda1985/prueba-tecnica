
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Collections.Generic;
using System.Linq;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            listaCarro();
            Console.ReadKey();
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

    }
}
