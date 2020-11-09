using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_PalabraClaveThis
{
    class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nom, int ed)
        {
            this.nombre = nom;
            this.edad = ed;
            this.Imprimir();
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + this.nombre);
            Console.WriteLine("Edad:" + this.edad);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan Carlos", 30);
        }
    }
}
