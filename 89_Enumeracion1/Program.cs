﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_Enumeracion1
{
    class JuegoDeCartas
    {
        public enum TipoCarta { oro, basto, copa, espada };

        private TipoCarta cartaActual;

        public void Imprimir()
        {
            cartaActual = TipoCarta.oro;
            Console.WriteLine("El valor actual es:" + cartaActual);
            cartaActual = TipoCarta.espada;
            Console.WriteLine("El valor actual es:" + cartaActual);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            JuegoDeCartas jc = new JuegoDeCartas();
            jc.Imprimir();
        }
    }
}
