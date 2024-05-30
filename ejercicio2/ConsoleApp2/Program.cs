using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

        /*Crear un programa que tenga una clase Calcular y que permita crear los métodos para
        sumar, restar, multiplicar y dividir, tenga un menú de opciones para realizar cada una
        de las operaciones, se deben de ingresar los números por teclado*/

{

    internal class Calcular
    {
        public static void Sumar(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"La respuesta es {result}");
        }

        public static void Restar(double a, double b)
        {
            double result = a - b;
            Console.WriteLine($"La respuesta es {result}");
        }

        public static void Multiplicar(double a, double b)
        {
            double result = a * b;
            Console.WriteLine($"La respuesta es {result}");
        }

        public static void Division (double a, double b)
        {
            double result = a / b;
            Console.WriteLine($"La respuesta es {result}");
        }
    }


    internal class Program
    {


        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("¿Qué operación quiere realizar? \n + (suma)\n - (resta)\n * (multiplicación)\n / (división)");
                string simbolo = Console.ReadLine();

                Console.WriteLine("Ingresa el primer número");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo número");
                double b = double.Parse(Console.ReadLine());

                if (simbolo == "+")
                {
                    Calcular.Sumar(a, b);
                }
                else if (simbolo == "-")
                {
                    Calcular.Restar(a, b);
                }
                else if (simbolo == "*")
                {
                    Calcular.Multiplicar(a, b);
                }
                else if (simbolo == "/")
                {
                    Calcular.Division(a, b);
                }


                Console.WriteLine("¿Desea ingresar otros datos? s/n");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                {
                    break;
                }

            } while (true);
        }
    }
}
