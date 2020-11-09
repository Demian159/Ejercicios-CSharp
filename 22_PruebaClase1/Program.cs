using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PruebaClase1
{
    class Persona
    {
        private string nombre;
        private int edad;

        public void Inicializar() {
            Console.WriteLine("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());
        }
        public void Imprimir() {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
        }
        public void EsMayorDeEdad() {
            if (edad >= 18){
                Console.WriteLine("Es Mayor de edad.");
            }else {
                Console.WriteLine("Es Menor de edad.");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Persona pers1 = new Persona();
            pers1.Inicializar();
            pers1.Imprimir();
            pers1.EsMayorDeEdad();
        }
    }
}
