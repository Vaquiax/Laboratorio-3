using System;
using System.Collections.Generic;
using System.Text;

namespace L14_AEVM1103526
{
    internal class CuentaBancaria
    {

        //ATRIBUTOS
        string titular; 
        string numeroCuenta;
        double saldo;

        //CONSTRUCTOR

        public CuentaBancaria(string titular, string numeroCuenta, double saldo)
        {
            this.titular = titular;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
        }

        //METODOS
        public void MostrarInformacion()
        {
            
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Número de Cuenta: {numeroCuenta}");
            Console.WriteLine($"Saldo: {saldo:C}");
        }

        public void Retirar(double cantidad)
        {
            Console.WriteLine($"Retirar {cantidad:C} de la cuenta de {titular}...");
            Console.WriteLine("¿Desea retirar el dinero?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (cantidad <= saldo)
                    {
                        saldo -= cantidad;
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente para realizar la operación.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Operación cancelada.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Operación cancelada.");
                    break;
            }

            Console.WriteLine("Saldo actualizado: " + saldo.ToString("C"));
            
        }

        public void Depositar(double cantidad)
        {
            Console.WriteLine($"Depositar {cantidad:C} en la cuenta de {titular}...");
            Console.WriteLine("¿Desea depositar el dinero?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (cantidad > 0)
                    {
                        saldo += cantidad;
                    }
                    else
                    {
                        Console.WriteLine("Cantidad no válida para realizar la operación.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Operación cancelada.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Operación cancelada.");
                    break;
            }

            Console.WriteLine("Saldo actualizado: " + saldo.ToString("C"));
        }

    }
}
