
using System.Linq;
using System;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arregloDeNumeros();
            Console.ReadKey();

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


    }
}
