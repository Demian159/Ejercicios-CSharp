using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _97_Propiedades1
{
    class Cuadrado
    {
        private int lado;

        public int Lado
        {
            set
            {
                lado = value;
            }
            get
            {
                return lado;
            }
        }

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
