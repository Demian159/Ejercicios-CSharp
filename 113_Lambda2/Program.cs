using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113_Lambda2
{
    public delegate bool Comparacion(int elemento);

    public class Estudiante
    {
        public String Nombre { get; set; }
        public int Nota { get; set; }
    }

    public class Curso
    {
        private Estudiante[] vec = new Estudiante[5];

        public void Cargar(int pos, Estudiante est)
        {
            vec[pos] = est;
        }

        public void ImprimirTodo()
        {
            foreach (var elemento in vec)
                Console.WriteLine("Nombre: {0} Nota: {1}", elemento.Nombre, elemento.Nota);
        }

        public void ImprimirSi(Comparacion compara)
        {
            foreach (var elemento in vec)
                if (compara(elemento.Nota))
                    Console.WriteLine("Nombre: {0} Nota: {1}", elemento.Nombre, elemento.Nota);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Curso curso1 = new Curso();
            curso1.Cargar(0, new Estudiante { Nombre = "jose", Nota = 9 });
            curso1.Cargar(1, new Estudiante { Nombre = "ana", Nota = 10 });
            curso1.Cargar(2, new Estudiante { Nombre = "luis", Nota = 2 });
            curso1.Cargar(3, new Estudiante { Nombre = "pedro", Nota = 7 });
            curso1.Cargar(4, new Estudiante { Nombre = "carla", Nota = 3 });
            Console.WriteLine("Listado completo de alumnos");
            curso1.ImprimirTodo();
            Console.WriteLine("Listado completo de estudiantes con notas mayores o iguales a 7");
            curso1.ImprimirSi((nota) => nota >= 7);
            Console.WriteLine("Listado completo de estudiantes que tienen un 2");
            curso1.ImprimirSi((nota) => nota == 2);
            Console.WriteLine("Listado completo de estudiantes empleando el método ImprimirSi");
            curso1.ImprimirSi((nota) => true);
            Console.ReadKey();
        }
    }
}
