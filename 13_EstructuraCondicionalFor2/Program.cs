using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_EstructuraCondicionalFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, valor, promedio;
            suma = 0;
            for (int i = 1; i <= 10; i++){
                Console.Write("Ingrese valor:");
                valor = int.Parse(Console.ReadLine());
                suma = suma + valor;
            }
            Console.WriteLine("La suma es: " + suma);
            promedio = suma / 10;
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
