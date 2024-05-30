using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
        /*Crear una clase Figuras y que tenga los métodos para hallar el cuadrado, rectángulo,
        triangulo, trapecio, circulo, también un método que permita seleccionar un menú, crear
        en la clase principal las opciones para cada uno de los métodos.*/

    class Figuras
    {
        public double CalcularAreaCuadrado(double lado)
        {
            return lado * lado;
        }

        public double CalcularAreaRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            return baseRectangulo * alturaRectangulo;
        }

        public double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }

        public double CalcularAreaTrapecio(double baseMayor, double baseMenor, double alturaTrapecio)
        {
            return ((baseMayor + baseMenor) * alturaTrapecio) / 2;
        }

        public double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public void SeleccionarMenu()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calcular área de cuadrado");
            Console.WriteLine("2. Calcular área de rectángulo");
            Console.WriteLine("3. Calcular área de triángulo");
            Console.WriteLine("4. Calcular área de trapecio");
            Console.WriteLine("5. Calcular área de círculo");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el lado del cuadrado:");
                    double ladoCuadrado = double.Parse(Console.ReadLine());
                    Console.WriteLine($"El área del cuadrado es: {CalcularAreaCuadrado(ladoCuadrado)}");
                    break;

                case 2:
                    Console.WriteLine("Ingrese la base del rectángulo:");
                    double baseRectangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del rectángulo:");
                    double alturaRectangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine($"El área del rectángulo es: {CalcularAreaRectangulo(baseRectangulo, alturaRectangulo)}");
                    break;

                case 3:
                    Console.WriteLine("Ingrese la base del triángulo:");
                    double baseTriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triángulo:");
                    double alturaTriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine($"El área del triángulo es: {CalcularAreaTriangulo(baseTriangulo, alturaTriangulo)}");
                    break;

                case 4:
                    Console.WriteLine("Ingrese la base mayor del trapecio:");
                    double baseMayorTrapecio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la base menor del trapecio:");
                    double baseMenorTrapecio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del trapecio:");
                    double alturaTrapecio = double.Parse(Console.ReadLine());
                    Console.WriteLine($"El área del trapecio es: {CalcularAreaTrapecio(baseMayorTrapecio, baseMenorTrapecio, alturaTrapecio)}");
                    break;

                case 5:
                    Console.WriteLine("Ingrese el radio del círculo:");
                    double radioCirculo = double.Parse(Console.ReadLine());
                    Console.WriteLine($"El área del círculo es: {CalcularAreaCirculo(radioCirculo)}");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Figuras figuras = new Figuras();

            do
            {
                figuras.SeleccionarMenu();

                Console.WriteLine("¿Desea realizar otra operación");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                {
                    break;
                }
            } while (true);
        }
    }
}
