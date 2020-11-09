using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_SobrecargaMetodos1
{
    class Titulo
    {
        private string tit;
        private int columna;
        private int fila;

        public Titulo(string t)
        {
            tit = t;
            columna = 1;
            fila = 1;
        }

        public Titulo(string t, int col, int fil)
        {
            tit = t;
            columna = col;
            fila = fil;
        }

        public void Imprimir()
        {
            Console.SetCursorPosition(columna, fila);
            Console.Write(tit);
        }

        static void Main(string[] args)
        {
            Titulo t1 = new Titulo("Hola Mundo");
            t1.Imprimir();
            Titulo t2 = new Titulo("Hola Mundo", 40, 12);
            t2.Imprimir();
            Console.ReadKey();
        }
    }
}
