using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_PruebaConstructor1
{
    class Operarios
    {
        private int[] sueldos;

        public Operarios()
        {
            sueldos = new int[5];
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.Write("Ingrese el sueldo:");
                string linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Operarios op = new Operarios();
            op.Imprimir();
        }
    }
}
