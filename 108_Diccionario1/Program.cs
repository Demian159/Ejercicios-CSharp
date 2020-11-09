using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108_Diccionario1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dicc1 = new Dictionary<string, string>();
            dicc1["rojo"] = "red";
            dicc1["verde"] = "green";
            dicc1["azul"] = "blue";
            dicc1["blanco"] = "white";
            foreach (KeyValuePair<string, string> elemento in dicc1)
                Console.WriteLine(elemento.Key + "=" + elemento.Value);
            if (dicc1.ContainsKey("rojo"))
                Console.WriteLine(dicc1["rojo"]);
            dicc1.Remove("rojo");
            if (dicc1.ContainsKey("rojo"))
                Console.WriteLine(dicc1["rojo"]);
            else
                Console.WriteLine("No existe la clave 'rojo'");

            Console.ReadKey();
        }
    }
}
