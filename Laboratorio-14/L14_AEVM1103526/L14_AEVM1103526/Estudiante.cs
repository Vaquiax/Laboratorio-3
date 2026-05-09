using System;
using System.Collections.Generic;
using System.Text;

namespace L14_AEVM1103526
{
    internal class Estudiante
    {
        //ATRIBUTOS
        string nombre;
        int edad;
        string grado;
        double[] notas;

        //CONSTRUCTOR

        public Estudiante(string nombre, int edad, string grado, double[] notas)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.grado = grado;
            this.notas = notas;
        }

        //METODOS

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Grado: {grado}");
            Console.WriteLine("Notas:");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {notas[i]}");
            }
        }

        public void CalcularPromedio()
        {
            double suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }
            double promedio = suma / notas.Length;
            Console.WriteLine($"El promedio de {nombre} es: {promedio:F2}");
        }

        public void aprobado()
        {
            if (notas.Length > 0)
            {

                double suma = 0;
                for (int i = 0; i < notas.Length; i++)
                {
                    suma += notas[i];
                }
                double promedio = suma / notas.Length;
                if (promedio >= 60)
                {
                    Console.WriteLine($"El estudiante {nombre} está aprobado.");
                }
                else
                {
                    Console.WriteLine($"El estudiante {nombre} no está aprobado.");
                }
            }
        }

        public void agregarNota(double nuevaNota)
        {
            Console.WriteLine($"¿Desea agregar una nueva nota para {nombre}?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    double[] nuevasNotas = new double[notas.Length + 1];
                    for (int i = 0; i < notas.Length; i++)
                    {
                        nuevasNotas[i] = notas[i];
                    }
                    nuevasNotas[nuevasNotas.Length - 1] = nuevaNota;
                    notas = nuevasNotas;
                    Console.WriteLine($"Nota agregada. Ahora {nombre} tiene {notas.Length} notas.");
                    break;
                case 2:
                    Console.WriteLine("Operación cancelada.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Operación cancelada.");
                    break;
            }
        }
    }
}   
