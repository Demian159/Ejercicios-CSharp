using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82_SobrecargaParametros2
{
    class Ventana
    {
        public void Mostrar(string mensaje)
        {
            Console.Write(mensaje);
        }

        public void Mostrar(string mensaje, int columna, int fila)
        {
            Console.SetCursorPosition(columna, fila);
            Console.Write(mensaje);
        }

        public void Mostrar(string mensaje, int columna, int fila, ConsoleColor colorletra)
        {
            Console.ForegroundColor = colorletra;
            Mostrar(mensaje, columna, fila);
        }

        public void Mostrar(string mensaje, int columna, int fila, ConsoleColor colorletra, ConsoleColor colorfondo)
        {
            Console.BackgroundColor = colorfondo;
            Mostrar(mensaje, columna, fila, colorletra);
        }

        static void Main(string[] args)
        {
            Ventana v = new Ventana();
            v.Mostrar("Hola Mundo");
            v.Mostrar("Hola Mundo", 30, 10);
            v.Mostrar("Hola Mundo", 30, 12, ConsoleColor.Red);
            v.Mostrar("Hola Mundo", 30, 14, ConsoleColor.Red, ConsoleColor.Blue);
            Console.ReadKey();
        }
    }
}
