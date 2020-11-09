using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78_ParametrosVariables1
{
    class Program
    {
        public int Sumar(params int[] p)
        {
            int su = 0;
            for (var f = 0; f < p.Length; f++)
            {
                su = su + p[f];
            }
            return su;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("La suma de 3,4,5 es ");
            Console.WriteLine(p.Sumar(3, 4, 5));
            Console.ReadKey();
        }
    }
}
