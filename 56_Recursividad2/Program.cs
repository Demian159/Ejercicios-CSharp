using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Recursividad2
{
    //Lo mismo que el anterior, stack overflow despues de escribir bastante hasta q la pila rebalsa
    public class Recursividad
    {

        void Imprimir(int x)
        {
            Console.Write(x + " ");
            Imprimir(x - 1);
        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            re.Imprimir(5);
        }
    }
}
