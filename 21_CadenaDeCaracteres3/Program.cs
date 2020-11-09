using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_CadenaDeCaracteres3
{
    class Program
    {
        static void Main(string[] args)
        {
            string apellido1, apellido2;
            Console.Write("Ingrese primer apellido:");
            apellido1 = Console.ReadLine();
            Console.Write("Ingrese segundo apellido:");
            apellido2 = Console.ReadLine();
            if (apellido1 == apellido2)
            {
                Console.Write("Los apellidos son iguales");
            }
            else
            {
                Console.Write("Los apellidos son distintos");
            }
            Console.ReadKey();
        }
    }
}
