using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Libreria
    {
        public static void SaludoInicio(string nombre)
        {
            Console.WriteLine($"Hola {nombre}");
        }

        public static void sumar2Numeros(int a, int b)
        {
            int resultado = a + b;

            Console.WriteLine($"El resultado es {resultado}");
        }

        public static void SaludoFin(string nombre)
        {
            Console.WriteLine($"Adios {nombre}");
        }
    }
}
