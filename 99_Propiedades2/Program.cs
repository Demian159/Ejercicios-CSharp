using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_Propiedades2
{
    //...
    class Cuadrado {
        public int Lado1 { get; set; } = 3;
        public int Lado2 { get; set; } = 3;
        public int Lado3 { get; set; } = 3;
        public int Lado4 { get; set; } = 3;

        public int RetornarPerimetro() {

            return Lado1 + Lado2 + Lado3 + Lado4;
        
        }

    }

    //...
    class Triangulo
    {
        public int Lado1 { get; set; } = 5;
        public int Lado2 { get; set; } = 5;
        public int Lado3 { get; set; } = 5;

        public int RetornarPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo { Lado1 = 10, Lado2 = 20, Lado3 = 30 };
            Console.WriteLine(triangulo1.RetornarPerimetro());
            Triangulo triangulo2 = new Triangulo { Lado3 = 30 };
            Console.WriteLine(triangulo2.RetornarPerimetro());
            Cuadrado cuadrado1 = new Cuadrado();
            Console.WriteLine(cuadrado1.RetornarPerimetro());
            Cuadrado cuadrado2 = new Cuadrado { Lado2 = 100 };
            Console.WriteLine(cuadrado2.RetornarPerimetro());
            Console.ReadKey();
        }
    }
}
