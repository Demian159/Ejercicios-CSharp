using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120_Interpolacion4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            Console.WriteLine($"La fecha y hora actual es {fecha:dd MM yyyy HH:mm:ss}");
            double precio = 10.252;
            Console.WriteLine($"La variable precio {precio:.##} con 2 decimales");
            Console.WriteLine($"La variable precio {precio:E} con formato exponencial");
            byte color = 255;
            Console.WriteLine($"La variable color {color:X} con formato exadecimal");
            Console.ReadKey();
        }
    }
}
