using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _96_Indexador3
{
    public enum DatoCasilla { agua, barco };

    class Tablero
    {
        private DatoCasilla[,] mat;

        public Tablero()
        {
            mat = new DatoCasilla[10, 10];
        }

        public void Graficar()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (mat[f, c] == DatoCasilla.agua)
                    {
                        Console.Write("0");
                    }
                    if (mat[f, c] == DatoCasilla.barco)
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }

        public DatoCasilla this[int fila, int columna]
        {
            set
            {
                mat[fila, columna] = value;
            }
            get
            {
                return mat[fila, columna];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tablero tablero1 = new Tablero();
            tablero1[0, 0] = DatoCasilla.barco;
            tablero1[0, 1] = DatoCasilla.barco;
            tablero1[0, 2] = DatoCasilla.barco;
            tablero1[0, 9] = DatoCasilla.barco;
            tablero1[1, 9] = DatoCasilla.barco;
            tablero1[2, 9] = DatoCasilla.barco;
            tablero1.Graficar();
            Console.WriteLine();
            if (tablero1[0, 0] == DatoCasilla.barco)
            {
                Console.WriteLine("Hay un barco en esta casilla");
            }
            else
            {
                if (tablero1[0, 0] == DatoCasilla.agua)
                {
                    Console.WriteLine("Agua");
                }
            }
            Console.ReadKey();
        }
    }
}
