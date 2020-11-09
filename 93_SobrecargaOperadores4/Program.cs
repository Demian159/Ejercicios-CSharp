using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _93_SobrecargaOperadores4
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

        public static bool operator ==(VectorEnteros v1, VectorEnteros v2)
        {
            for (int f = 0; f < v1.vec.Length; f++)
            {
                if (v1.vec[f] != v2.vec[f])
                    return false;
            }
            return true;
        }

        public static bool operator !=(VectorEnteros v1, VectorEnteros v2)
        {
            for (int f = 0; f < v1.vec.Length; f++)
            {
                if (v1.vec[f] == v2.vec[f])
                    return false;
            }
            return true;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            VectorEnteros v1 = new VectorEnteros();
            Console.WriteLine("Carga del primer vector");
            v1.Cargar();
            VectorEnteros v2 = new VectorEnteros();
            Console.WriteLine("Carga del segundo vector");
            v2.Cargar();
            if (v1 == v2)
                Console.Write("Todos los elementos son iguales");
            else
                Console.Write("No todos los elementos son iguales");
            Console.ReadKey();
        }
    }
}
