using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3

        /*Crea una clase llamada Cuenta: Atributos: titular y saldo, Método para depositar
        una cantidad (cantidad tipo double),Método para retirar saldo, Método para ver los
        datos, Si ingresa una cantidad negativa a la cuenta debe mostrar el mensaje “Error en
        el monto ingresado”.*/

{
    internal class Cuenta
    {
        public string titular;
        public double saldo;

        public Cuenta(string titular)
        {
            this.titular = titular;
            this.saldo = 0;
        }


        public void Depositar(double monto)
        {
            if (monto >= 0)
            {
                saldo += monto;
                Console.WriteLine($"Se han depositado {monto} unidades. Saldo actual: {saldo}");
            }
            else
            {
                Console.WriteLine("Error en el monto ingresado");
            }
        }

        public void Retirar(double monto)
        {
            if (monto >= 0)
            {
                if (monto <= saldo)
                {
                    saldo -= monto;
                    Console.WriteLine($"Se han retirado {monto} unidades. Saldo actual: {saldo}");
                }
                else
                {
                    Console.WriteLine("Fondos insuficientes");
                }
            }
            else
            {
                Console.WriteLine("Error en el monto ingresado");
            }
        }

        public void Datos()
        {
            Console.WriteLine($"Titular: {titular}, Saldo: {saldo}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del titular");
            string titular = Console.ReadLine();

            Cuenta cuenta = new Cuenta(titular);

            do
            {
                

                Console.WriteLine("¿Desea depositar? s/n");
                string dRes = Console.ReadLine().ToLower();

                if ( dRes != "s")
                {
                    break;

                } else{
                    Console.WriteLine("Ingrese la cantidad a adepositar");
                    double monto = double.Parse(Console.ReadLine());

                    cuenta.Depositar(monto);
                }

                Console.WriteLine("¿Desea retirar? s/n");
                string dRet = Console.ReadLine().ToLower();

                if (dRet != "s")
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Ingrese la cantidad a adepositar");
                    double monto = double.Parse(Console.ReadLine());

                    cuenta.Retirar(monto);
                }

                Console.WriteLine("¿Desea ver sus datos? s/n");
                string dDat = Console.ReadLine().ToLower();

                if (dDat != "s")
                {
                    break;

                }
                else
                {
                    cuenta.Datos();
                }



                Console.WriteLine("¿Desea hacer otros cambios en su cuenta? s/n");
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
