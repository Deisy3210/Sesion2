using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppnLongitudNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            String numero;
            int num;
            Console.WriteLine("Encontrar longitud de numero");
            Console.WriteLine("Digite un numero entre 1 y 99:");
            numero = Console.ReadLine();
            num = int.Parse(numero);
            if(numero.Length<=2 && num>0)
            {
                Console.WriteLine("El numero es positivo");
                if (numero.Length == 2)
                {
                    Console.WriteLine("El numero tiene dos digitos");
                }
                else
                {
                    Console.WriteLine("El numero tiene un digito");
                }
            }
            else
            {
                Console.WriteLine("Numero fuera de rango o es negativo");
            }
            Console.ReadKey();
        }
    }
}
