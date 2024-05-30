using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
            /*Menú de Opciones:
            a) Elaborar un programa que calcule el MCD de dos números enteros.
            b) Elaborar un programa para reportar todos los divisores de un número
            entero.
            c) Desarrollar un programa para reportar los factores primos de un número entero.
            d) Programa para ingresar un númera y se reporte si es prima o na.
            e) Escribir un programa que permita leer dos números y reportar si son amigos o no. 
                Se dice que dos números son amigos si cada uno de ellos es igual a la suma de los divisores (menares que el número) del otra. Ejemplo 220 y 284 son amigos.
            f) Realizar un menú que tenga las opciones para desarrollar los 5 programas mencionados e incluir la opción salir.
            MENU DE OPCIONES
            *****
            *********
            1.- MCD DE 2 NUMEROS ENTERO
            2.- DIVISORES DE UN NUMERO ENTERO
            3.- FACTORES PRIMO DE UN NUMERO ENTERO
            4.- NUMERO PRIMO O NO
            5.- NUMEROS AMIGOS
            6.- SALIR
            Ingrese su opcion:*/


    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                int opcion;
                    MostrarMenu();
                    
                    Console.WriteLine();
                    Console.Write("Seleccione una opción: ");
                    opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                    {
                        case 1:
                            CalcularMCD();
                            break;
                        case 2:
                            ReportarDivisores();
                            break;
                        case 3:
                            ReportarFactoresPrimos();
                            break;
                        case 4:
                            ReportarPrimoSiNo();
                            break;
                        case 5:
                            VerificarAmigos();
                            break;
                        case 6:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                            break;
                    }

                Console.WriteLine("¿Desea hacer otra operación? s/n");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                {
                    break;
                }
            } while (true);


            Console.ReadKey();

        }

        static void MostrarMenu()
        {
            Console.WriteLine("Menú de Opciones:");
            Console.WriteLine("1. Calcular el MCD de dos números enteros.");
            Console.WriteLine("2. Reportar todos los divisores de un número entero.");
            Console.WriteLine("3. Reportar los factores primos de un número entero.");
            Console.WriteLine("4. Reportar si un número entero es primo o no.");
            Console.WriteLine("5. Verificar si dos números son amigos.");
            Console.WriteLine("6. Salir.");
            
        }


        static void CalcularMCD()
        {
            Console.WriteLine("Ingrese el primer número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            int a = num1;
            int b = num2;

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            int mcd = a;
            Console.WriteLine($"El MCD de {num1} y {num2} es: {mcd}");
        }

        static void ReportarDivisores()
        {
            Console.WriteLine("Ingrese un número entero:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Los divisores de {num} son:");
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static void ReportarFactoresPrimos()
        {
            Console.WriteLine("Ingrese un número entero:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Los factores primos de {num} son:");
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
            }
            Console.WriteLine();
        }

        static void ReportarPrimoSiNo()
        {
            Console.WriteLine("Ingrese un número entero:");
            int num = int.Parse(Console.ReadLine());

            bool esPrimo = true;

            if (num <= 1 || (num > 2 && num % 2 == 0) || (num > 3 && num % 3 == 0))
            {
                esPrimo = false;
            }
            else
            {
                int i = 5;
                while (i * i <= num)
                {
                    if (num % i == 0 || num % (i + 2) == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                    i += 6;
                }
            }

            if (esPrimo)
            {
                Console.WriteLine($"{num} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{num} no es un número primo.");
            }
        }

        static void VerificarAmigos()
        {
            Console.WriteLine("Ingrese el primer número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            int sumaDivisores1 = 0;
            int sumaDivisores2 = 0;

            for (int i = 1; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    sumaDivisores1 += i;
                }
            }

            for (int i = 1; i < num2; i++)
            {
                if (num2 % i == 0)
                {
                    sumaDivisores2 += i;
                }
            }

            if (sumaDivisores1 == num2 && sumaDivisores2 == num1)
            {
                Console.WriteLine($"{num1} y {num2} son números amigos.");
            }
            else
            {
                Console.WriteLine($"{num1} y {num2} no son números amigos.");
            }
        }
    }
}
