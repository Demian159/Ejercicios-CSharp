using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_Recursividad1
{
    //Stack Overflow, no tiene salida.
    public class Recursividad
    {

        void Repetir()
        {
            Repetir();
        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            re.Repetir();
        }

    }
}
