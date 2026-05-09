using System;
using System.Collections.Generic;
using System.Text;

namespace L14_AEVM1103526
{
    internal class Producto
    {
        //ATRIBUTOS
        string nombre;
        string precio;
        int cantidad;

        //CONSTRUCTOR
        public Producto (string nombre, string precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        //METODOS

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre del producto: {nombre}");
            Console.WriteLine($"Precio: {precio}");
            Console.WriteLine($"Cantidad: {cantidad}");
        }

        public void Vender(int cantidadVendida)
        {
            Console.WriteLine($"Vender {cantidadVendida} unidades de {nombre}...");
            Console.WriteLine("¿Desea realizar la venta?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    if (cantidadVendida <= cantidad)
                    {
                        cantidad -= cantidadVendida;
                        Console.WriteLine($"Venta realizada. Quedan {cantidad} unidades de {nombre}.");
                    }
                    else
                    {
                        Console.WriteLine("Cantidad insuficiente para realizar la venta.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Venta cancelada.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Venta cancelada.");
                    break;
            }
        }

        public void Reabastecer(int cantidadReabastecida)
        {
            Console.WriteLine($"Reabastecer {cantidadReabastecida} unidades de {nombre}...");
            Console.WriteLine("¿Desea realizar el reabastecimiento?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    cantidad += cantidadReabastecida;
                    Console.WriteLine($"Reabastecimiento realizado. Ahora hay {cantidad} unidades de {nombre}.");
                    break;
                case 2:
                    Console.WriteLine("Reabastecimiento cancelado.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Reabastecimiento cancelado.");
                    break;
            }
        }
    }
}
