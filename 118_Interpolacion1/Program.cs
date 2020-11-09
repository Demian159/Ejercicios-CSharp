using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _118_Interpolacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese primer valor:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());
            int suma = valor1 + valor2;
            Console.WriteLine($"La suma de {valor1} + {valor2} es {suma}");
            Console.ReadKey();
        }
    }
}
