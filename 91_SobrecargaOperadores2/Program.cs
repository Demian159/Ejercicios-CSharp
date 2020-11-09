using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91_SobrecargaOperadores2
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

        public static VectorEnteros operator *(VectorEnteros v1, int valor)
        {
            VectorEnteros resu = new VectorEnteros();
            for (int f = 0; f < resu.vec.Length; f++)
            {
                resu.vec[f] = v1.vec[f] * valor;
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
            VectorEnteros vr;
            Console.WriteLine("Primer Vector");
            v1.Imprimir();
            vr = v1 * 10;
            Console.WriteLine("Vector resultante");
            vr.Imprimir();
            Console.ReadKey();
        }
    }
}
