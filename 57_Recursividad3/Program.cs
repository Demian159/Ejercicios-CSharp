using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_Recursividad3
{
    public class Recursividad
    {

        void imprimir(int x)
        {
            if (x > 0)
            {
                Console.WriteLine(x);
                imprimir(x - 1);
            }
        }
        static void Main(string[] args) {
            Recursividad re = new Recursividad();
            re.imprimir(5);
            Console.ReadKey();
        }
    }
}
