
using System;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cadenaDeTexto();
            Console.ReadKey();
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

    }
}
