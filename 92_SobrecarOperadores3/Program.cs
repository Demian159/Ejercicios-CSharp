using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _92_SobrecarOperadores3
{
    class VectorEnteros
    {
        private int[] vec;

        public VectorEnteros()
        {
            vec = new int[5];
        }

        public void Cargar()
        {
            for (int f = 0; f < vec.Length; f++)
            {
                Console.Write("Ingrese componente:");
                vec[f] = int.Parse(Console.ReadLine());
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < vec.Length; f++)
            {
                Console.Write(vec[f] + " ");
            }
            Console.WriteLine();
        }

        public static VectorEnteros operator ++(VectorEnteros v)
        {
            VectorEnteros resu = new VectorEnteros();
            for (int f = 0; f < v.vec.Length; f++)
            {
                resu.vec[f] = v.vec[f] + 1;
            }
            return resu;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VectorEnteros v1 = new VectorEnteros();
            Console.WriteLine("Carga del vector");
            v1.Cargar();
            Console.WriteLine("Impresión del vector");
            v1.Imprimir();
            v1++;
            Console.WriteLine("Impresión del vector luego del operador ++");
            v1.Imprimir();
            Console.ReadKey();
        }
    }
}
