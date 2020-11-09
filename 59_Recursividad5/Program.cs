using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_Recursividad5
{
    public class Recursividad
    {

        int Factorial(int fact)
        {
            if (fact > 0)
            {
                int valor = fact * Factorial(fact - 1);
                return valor;
            }
            else
                return 1;
        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            int f = re.Factorial(4);
            Console.WriteLine("El factorial de 4 es " + f);
            Console.ReadKey();
        }
    }
}
