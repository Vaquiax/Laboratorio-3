using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace L11_AEVM1103526_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //BIENVENIDA
            Console.WriteLine("================================");
            Console.WriteLine("¡BIENVENIDO AL LABORATORIO 11!");
            Console.WriteLine("Póngase cómodo...");
            Console.WriteLine("Traiga sus palomitas...");
            Console.WriteLine("Bueno, tal vez no tanto...");
            Console.WriteLine("================================");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Presione Enter para continuar...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.Clear();
            //FINALIZA BIENVENIDA

            //MENÚ
            int contadormenu = 0;
            while (contadormenu == 0)
            {
                Console.WriteLine("===============MENÚ PRINCIPAL================");
                Console.WriteLine("1. Detección de Palíndromos");
                Console.WriteLine("2. Traducción de palabras");
                Console.WriteLine("3. Calificación de un curso");
                Console.WriteLine("4. Simulación de pagos de planilla");
                Console.WriteLine("================================");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Ingrese el número del ejercicio a acceder:");
                Console.ForegroundColor = ConsoleColor.White;
                
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    //EJERCICIO 1
                    case 1:
                        int coincidencias = 0;
                        Console.WriteLine("================================");
                        Console.WriteLine("Ejercicio #1");
                        Console.WriteLine("Detección de Palíndromos");
                        Console.WriteLine("================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("================================");
                        Console.WriteLine("Porfavor ingrese una palabra:");
                        string palabra = Console.ReadLine();
                        Console.WriteLine("================================");

                        System.Threading.Thread.Sleep(750);
                        Console.Write("Analizando palabra");
                        System.Threading.Thread.Sleep(550);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(550);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(550);
                        Console.WriteLine(".");
                        System.Threading.Thread.Sleep(650);

                        Console.WriteLine(palabra);

                        System.Threading.Thread.Sleep(350);



                        for (int i = palabra.Length - 1; i >= 0; i--)
                        {

                            Console.Write(palabra[i]);
                            System.Threading.Thread.Sleep(550);

                        }
                        Console.WriteLine("");

                        palabra = palabra.ToLower();

                        for (int i = palabra.Length - 1; i >= 0; i--)
                        {
                            if (palabra[i] == palabra[(palabra.Length - 1 - i)])
                            {
                                coincidencias++;

                            }

                        }
                        if (coincidencias == palabra.Length)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("La palabra es un palíndromo");
                        }
                        else if (coincidencias != palabra.Length)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("La palabra no es un palíndromo");
                        }
                        Console.WriteLine("================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione Enter para volver al menú...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    //FINALIZA EJERCICIO 1

                    //EJERCICIO 2
                    case 2:
                        int Contadorpractica = 0;
                        int Contadoridioma = 0;

                        Console.WriteLine("================================");
                        Console.WriteLine("Ejercicio #2");
                        Console.WriteLine("Traducción de palabras");
                        Console.WriteLine("================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();

                        while (Contadoridioma == 0)
                        {
                            
                            

                            Console.WriteLine("===============IDIOMAS================");
                            Console.WriteLine("1. Practicar lección");
                            Console.WriteLine("2. Terminar lección");
                            Console.WriteLine("======================================");
                            Console.WriteLine("Ingrese el número de una opción:");
                            int opcionidioma = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (opcionidioma)
                            {
                                case 1:
                                    
                                    Contadorpractica++;
                                    if (Contadorpractica == 1)
                                    {
                                        Console.WriteLine("======================================");
                                        Console.WriteLine("PRIMERA LECCIÓN DEL DÍA!");
                                        Console.WriteLine("      bienvenido");
                                        Console.WriteLine("======================================");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Presione Enter para continuar...");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                    Console.WriteLine("======================================");
                                    Console.WriteLine("Lecciones terminadas hoy: " + (Contadorpractica - 1));
                                    Console.WriteLine("Vamos con la lección!");
                                    Console.WriteLine("======================================");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Presione Enter para continuar...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadLine();
                                    Console.Clear();

                                    Console.WriteLine("======================================");
                                    Console.WriteLine("Ingrese un color en español:");
                                    string color = Console.ReadLine();

                                    Console.Write("Traduciendo palabra");
                                    System.Threading.Thread.Sleep(550);
                                    Console.Write(".");
                                    System.Threading.Thread.Sleep(550);
                                    Console.Write(".");
                                    System.Threading.Thread.Sleep(550);
                                    Console.WriteLine(".");
                                    System.Threading.Thread.Sleep(650);
                                    colorelegir(color, ref Contadorpractica);
                                    Console.WriteLine("================================");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Presione Enter para volver al menú...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Contadoridioma++;
                                    Console.WriteLine("======================================");
                                    Console.WriteLine("LECCIÓN TERMINADA!");
                                    Console.WriteLine("Lecciones terminadas hoy: " + Contadorpractica);
                                    Console.WriteLine("¡Buen trabajo el día de hoy!");
                                    Console.WriteLine("======================================");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Presione Enter para volver al menú...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                            }
                        }


                        break;

                    //FINALIZA EJERCICIO 2

                    //EJERCICIO 3
                    case 3:
                        Console.WriteLine("===============RENDIMIENTO================");
                        Console.WriteLine("Ejercicio #3");
                        Console.WriteLine("Calificación de un curso");
                        Console.WriteLine("==========================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();

                        int[] numeros = new int[10];

                        for (int i = 0; i < 10; i++)
                        {
                            Random random = new Random();

                            numeros[i] = random.Next(50, 101);

                        }
                        int contadorrendimiento = 0;
                        while (contadorrendimiento == 0)
                        {
                            Console.WriteLine("===============RENDIMIENTO================");
                            Console.WriteLine("1. Reporte de rendimiento");
                            Console.WriteLine("2. Estadísticas");
                            Console.WriteLine("3. Salir");
                            Console.WriteLine("==========================================");
                            Console.WriteLine("Ingrese el número de una opción:");
                            int opcioncalificación = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (opcioncalificación)
                            {
                                case 1:
                                    Console.WriteLine("===============RENDIMIENTO================");
                                    reporterendimiento(numeros);
                                    Console.WriteLine("==========================================");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Presione Enter para continuar...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.WriteLine("===============RENDIMIENTO================");
                                    double suma = 0;
                                    int min = numeros[0];
                                    int max = numeros[0];
                                    for (int i = 0; i < 9; i++)
                                    {
                                        if (numeros[i] > numeros[i + 1])
                                        {
                                            min = numeros[i + 1];
                                        }
                                        if (numeros[i] < numeros[i + 1])
                                        {
                                            max = numeros[i + 1];
                                        }
                                    }

                                    for (int i = 0; i < 10; i++)
                                    {
                                        suma = numeros[i] + suma;
                                    }

                                    Console.WriteLine("Calificación más baja: " + min);
                                    Console.WriteLine("Calificación más alta: " + max);
                                    Console.WriteLine("Promedio de calificaciones: " + (suma / 10.0));
                                    Console.WriteLine("==========================================");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Presione Enter para continuar...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Presione Enter para volver al menú...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    contadorrendimiento++;
                                    Console.Clear();
                                    break;

                                    

                            }
                            
                        }
                        break;

                    //FINALIZA EJERCICIO 3

                    //EJERCICIO 4
                    case 4:
                        Console.WriteLine("===============PAGOS================");
                        Console.WriteLine("Ejercicio #4");
                        Console.WriteLine("Simulación de pagos de planilla");
                        Console.WriteLine("====================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();


                        Console.WriteLine("===============PAGOS================");
                        double montoapagar;
                        string[] trabjadores = new string[6] { "Ana", "Mario", "Saúl", "Karla", "María", "José"};
                        double[] pagos = new double[6] {100, 125.50, 98.65, 125, 132.50, 102.50};
                        double[] horas = new double[6];

                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine("Ingrese las horas trabajadas en la semana de " + trabjadores[i] + ":");
                            horas[i] = double.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("====================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("===============PAGOS================");
                        for (int i = 0; i < 6; i++)
                        {
                            montoapagar = horas[i] * pagos[i];
                            if (horas[i] > 40)
                            {
                                montoapagar = (40 * pagos[i]) + ((horas[i] - 40) * (pagos[i] * 1.5));
                            }
                            Console.WriteLine("Monto a pagar a " + trabjadores[i] + ": " + montoapagar);
                        }
                        Console.WriteLine("====================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione Enter para volver al menú...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    //FINALIZA EJERCICIO 4




                    //OPCION NO VALIDA
                    default:
                        Console.WriteLine("===============PAGOS================");
                        Console.WriteLine("Opción no válida");
                        Console.WriteLine("====================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Presione Enter para volver al menú...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine() ;

                        break;
                }


            }
            void colorelegir(string color, ref int contadorpractica)
            {
                color = color.ToLower();
                switch (color)
                {

                    case "rojo":
                        Console.WriteLine("El color en inglés es: red");
                        Console.WriteLine("El color en italiano es: rosso");

                        break;
                    case "azul":
                        Console.WriteLine("El color en inglés es: blue");
                        Console.WriteLine("El color en italiano es: blu");
                        break;
                    case "amarillo":
                        Console.WriteLine("El color en inglés es: yellow");
                        Console.WriteLine("EL color en italiano es: giallo");
                        break;
                    case "blanco":
                        Console.WriteLine("El color en inglés es: white");
                        Console.WriteLine("El color en italiano es: bianco");
                        break;
                    case "verde":
                        Console.WriteLine("El color en inglés es: green");
                        Console.WriteLine("El color en italiano es: verde");
                        break;
                    default:
                        Console.WriteLine("Color no reconocido, porfavor ingrese un color válido");
                        contadorpractica--;
                        break;


                }
                
            }
            void reporterendimiento(int[] numeros)
            {
                Console.WriteLine("Reporte de rendimiento:");
                Array.Sort(numeros);
                for (int i = 0; i < 10; i++)
                {
                    if ((numeros[i] > 49) && (numeros[i] < 65))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(numeros[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                    } else if ((numeros[i] > 64) && (numeros[i] < 80))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(numeros[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                    } else if ((numeros[i] > 79) && (numeros[i] < 101))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(numeros[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
            }
        }
    }
}
    
