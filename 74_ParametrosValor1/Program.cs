using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_ParametrosValor1
{
    class Program
    {
        public void MostrarRango(int menor, int mayor)
        {
            for (var x = menor; x <= mayor; x++)
            {
                Console.Write(x + " ");
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.MostrarRango(1, 25);
            Console.ReadKey();
        }
    }
}
