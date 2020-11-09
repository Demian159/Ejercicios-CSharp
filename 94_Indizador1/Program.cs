using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94_Indizador1
{
    class Program
    {
        class A
        {
            private int[] vec;
            public A()
            {
                vec = new int[3];
            }

            public int this[int indice]
            {
                set
                {
                    vec[indice] = value;
                }
                get
                {
                    return vec[indice];
                }
            }
        }

        static void Main(string[] args)
        {
            A obj1 = new A();
            obj1[0] = 7;
            obj1[1] = 34;
            obj1[2] = 45;
            Console.WriteLine(obj1[0]);
            Console.WriteLine(obj1[1]);
            Console.WriteLine(obj1[2]);
            Console.ReadKey();
        }
    }
}
