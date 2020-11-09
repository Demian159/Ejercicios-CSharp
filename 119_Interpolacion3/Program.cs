using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _119_Interpolacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alumnos = { "juan", "mariana", "pedro" };
            int[] notas = { 10, 7, 5 };
            for (int f = 0; f < alumnos.Length; f++)
                Console.WriteLine($"{alumnos[f],-20} {notas[f],2}");
            Console.ReadKey();
        }
    }
}
