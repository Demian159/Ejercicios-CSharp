using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98_Propiedades1._2
{
    class Cuadrado
    {
        public int Lado { get; set; }

        public int RetornarSuperficie()
        {
            return Lado * Lado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado1 = new Cuadrado();
            cuadrado1.Lado = 30;
            Console.WriteLine("Su superficie es:" + cuadrado1.RetornarSuperficie());
            Console.ReadKey();
        }
    }
}
