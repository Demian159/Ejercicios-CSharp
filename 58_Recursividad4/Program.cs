using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_Recursividad4
{
    public class Recursividad
    {

        void Imprimir(int x)
        {
            if (x > 0)
            {
                Imprimir(x - 1);
                Console.WriteLine(x);
            }
        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            re.Imprimir(5);
            Console.ReadKey();
        }
    }
}
