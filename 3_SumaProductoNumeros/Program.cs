using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SumaProductoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, producto;
            String linea;
            Console.WriteLine("Ingrese el primer numero a operar: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero a operar: ");
            num2 = int.Parse(Console.ReadLine());
            suma = num1 + num2;
            producto = num1 * num2;
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Producto: " + producto);
            Console.ReadKey();
        }
    }
}
