using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitch2
{
    class Program
    {
        static void Main(string[] args)
        {
            String numero;

            Console.WriteLine("Ingrese un numero entre 1 y 5");
            numero = Console.ReadLine();

            switch (numero)
            {
                case "1":
                    Console.WriteLine("UNO");
                    break;

                case "2":
                    Console.WriteLine("DOS");
                    break;

                case "3":
                    Console.WriteLine("TRES");
                    break;

                case "4":
                    Console.WriteLine("CUATRO");
                    break;

                case "5":
                    Console.WriteLine("CINCO");
                    break;

                default:
                    Console.WriteLine("Numero fuera de rango");
                    break;
            }

            Console.ReadKey();

        }
    }
}
