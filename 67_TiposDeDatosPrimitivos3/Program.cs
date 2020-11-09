using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_TiposDeDatosPrimitivos3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor mínimo y máximo para tipo de dato float.");
            Console.WriteLine("Mínimo:" + float.MinValue);
            Console.WriteLine("Máximo:" + float.MaxValue);
            Console.WriteLine("Valor mínimo y máximo para tipo de dato double.");
            Console.WriteLine("Mínimo:" + double.MinValue);
            Console.WriteLine("Máximo:" + double.MaxValue);
            Console.WriteLine("Valor mínimo y máximo para tipo de dato decimal.");
            Console.WriteLine("Mínimo:" + decimal.MinValue);
            Console.WriteLine("Máximo:" + decimal.MaxValue);
            Console.ReadKey();
        }
    }
}
