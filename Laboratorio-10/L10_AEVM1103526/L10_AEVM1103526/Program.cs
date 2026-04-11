namespace L10_AEVM1103526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("================LABORATORIO 10================");
            Console.WriteLine("Bienvenido al laboratorio 10!");
            Console.WriteLine("==============================================");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.Clear();
            
            int contador = 0;
            while (contador == 0) {

            int opcion;
            Console.WriteLine("================LABORATORIO 10================");
            Console.WriteLine("Escriba el número según el ejercicio al que quiera ingresar:");
            Console.WriteLine("1. Suma de dígitos");
            Console.WriteLine("2. Correo institucional");
            Console.WriteLine("3. Conversión de temperatura");
            Console.WriteLine("4. Sistema de puntos de estudiante");
            Console.WriteLine("5. Salir");
            Console.WriteLine("==============================================");

                opcion = int.Parse(Console.ReadLine());
            Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("================LABORATORIO 10================");
                        Console.WriteLine("Ejercicio 1");
                        Console.WriteLine("Escriba un número");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("El total de la suma de los dígitos es: " + suma(numero));
                        Console.WriteLine("==============================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case 2:
                        Console.WriteLine("================LABORATORIO 10================");
                        Console.WriteLine("Ejercicio 2");
                        Console.WriteLine("Ingrese su primer nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su segundo nombre");
                        string segundoNombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su apellido paterno");
                        string apellidoPaterno = Console.ReadLine();
                        Console.WriteLine("Ingrese su apellido materno");
                        string apellidoMaterno = Console.ReadLine();

                        Console.WriteLine(nombre[0].ToString() + segundoNombre[0].ToString() + apellidoPaterno + apellidoMaterno[0].ToString() + "@correo.url.edu.gt");
                        Console.WriteLine("==============================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case 3:
                        Console.WriteLine("================LABORATORIO 10================");
                        double Faren = 0;
                        Console.WriteLine("Ejercicio 3");
                        Console.WriteLine("Ingrese la temperatura en Celsius:");
                        string Grados = Console.ReadLine();

                        Farenheit(Grados, ref Faren);


                        Console.WriteLine("La temperatura en Farenheit es: " + Faren);
                        Console.WriteLine("==============================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case 4:
                        Console.WriteLine("================SISTEMA DE PUNTOS================");
                        Console.WriteLine("Ejercicio 4");
                        Console.WriteLine("Ingresando al sistema de puntos de la universidad:");
                        Console.WriteLine("RAFAEL LANDIVAR...");
                        Console.WriteLine("==============================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("================SISTEMA DE PUNTOS================");
                        Console.Write("Ingrese el nombre del Estudiante: ");

                        string Nombre = Console.ReadLine();
                        Console.WriteLine("==============================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();


                        int opcionsistema;
                        int puntos = 0;


                        Console.Clear();
                        int contadorsistema = 0;
                        while (contadorsistema < 1)
                        {
                            Console.WriteLine("================SISTEMA DE PUNTOS================");
                            Console.WriteLine("                 " + Nombre);
                            Console.WriteLine("Escriba el número según la acción que desea realizar:");
                            Console.WriteLine("1. Agregar puntos");
                            Console.WriteLine("2. Quitar puntos");
                            Console.WriteLine("3. Obtener nivel");
                            Console.WriteLine("4. Evaluar estado");
                            Console.WriteLine("==============================================");
                            opcionsistema = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (opcionsistema)
                            {
                                case 1:
                                    Console.WriteLine("================SISTEMA DE PUNTOS================");
                                    Console.WriteLine("Se han agregado 10 puntos a: " + Nombre);
                                    AgregarPuntos(ref puntos);
                                    Console.WriteLine("==============================================");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Presione ENTER para continuar...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.WriteLine("================SISTEMA DE PUNTOS================");
                                    Console.WriteLine("Se han restado 10 puntos a " + Nombre);
                                    Console.WriteLine("Ingrese la cantidad de puntos a quitar:");
                                    QuitarPuntos(ref puntos);
                                    Console.WriteLine("==============================================");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Presione ENTER para continuar...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.WriteLine("================SISTEMA DE PUNTOS================");
                                    Console.WriteLine("Puntos actuales: " + puntos);

                                    ObtenerNivel(puntos);
                                    Console.WriteLine("==============================================");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Presione ENTER para continuar...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case 4:
                                    Console.WriteLine("================SISTEMA DE PUNTOS================");

                                    Console.WriteLine("Puntos finales: " + puntos);

                                    EvaluarEstado(puntos);
                                    Console.WriteLine("==============================================");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Presione ENTER para continuar...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadLine();
                                    Console.Clear();
                                    contadorsistema++;


                                    break;
                                default:
                                    Console.WriteLine("================LABORATORIO 10================");
                                    Console.WriteLine("Opción no válida. Por favor, seleccione un número del 1 al 4.");
                                    Console.WriteLine("==============================================");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Presione ENTER para continuar...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadLine();
                                    break;
                            }
                        }

                        break;

                        case 5:
                        Console.WriteLine("================LABORATORIO 10================");
                        Console.WriteLine("Gracias por participar en el laboratorio 10!");
                        Console.WriteLine("Nos vemos en el próximo laboratorio jeje...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione ENTER para SALIR...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        contador++;
                        break;
                }



                    int suma(int numero)
                    {
                        int sumas = 0;
                        while (numero > 0)
                        {
                            sumas = sumas + (numero % 10);
                            numero = numero / 10;
                        }
                        return sumas;
                    }
                    void Farenheit(string Grados, ref double Faren)
                    {
                        Grados.Substring(0);
                        double Celsius = double.Parse(Grados);
                        Faren = (Celsius * 9 / 5) + 32;
                    }

                    void AgregarPuntos(ref int puntos)
                    {
                        puntos = puntos + 10;
                        if (puntos > 100)
                        {
                            puntos = 100;
                            Console.WriteLine("El estudiante ha alcanzado el máximo de puntos");
                        }
                        Console.WriteLine("Puntos actuales: " + puntos);
                    }
                    void QuitarPuntos(ref int puntos)
                    {

                        puntos = puntos - 7;
                        if (puntos < 0)
                        {
                            puntos = 0;
                            Console.WriteLine("El estudiante ha alcanzado el mínimo de puntos");
                        }
                        Console.WriteLine("Puntos actuales: " + puntos);
                    }
                    void ObtenerNivel(int puntos)
                    {
                        if (puntos >= 80)
                        {
                            Console.WriteLine("Nivel: Avanzado");
                        }
                        else if ((puntos >= 50) && (puntos < 80))
                        {
                            Console.WriteLine("Nivel: Intermedio");
                        }
                        else if (puntos < 50)
                        {
                            Console.WriteLine("Nivel: Básico");
                        }
                    }
                    void EvaluarEstado(int puntos)
                    {
                        if (puntos == 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("EXCELENTE");
                             Console.ForegroundColor = ConsoleColor.White;
                         }
                        else if ((puntos >= 70) && (puntos < 100))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("APROBADO");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (puntos < 70)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("REPROBADO");
                            Console.ForegroundColor = ConsoleColor.White;
                    }
                    }
            }
        }
    }
}