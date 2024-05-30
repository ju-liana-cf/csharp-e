using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program

        /*Crear una biblioteca propia de usuario llamado Libreria.cs, en la cual implementara
          las siguientes funciones saludoInicio(), saludoFin() y sumar2Numeros(int a, int b).*/

    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese su nombre");
                string nombre = Console.ReadLine();

                Libreria.SaludoInicio(nombre);

                Console.WriteLine("Ingrese primer número");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo número");
                int b = int.Parse(Console.ReadLine());

                Libreria.sumar2Numeros(a, b);

                Libreria.SaludoFin(nombre);

                Console.WriteLine("¿Desea ingresar otros datos? s/n");
                string r = Console.ReadLine().ToLower();

                if (r != "s")
                {
                    break;
                }

            } while (true);

            Console.ReadKey();
        }
    }
}
