
using System;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fibonacci();
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


    }
}
