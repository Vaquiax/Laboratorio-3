using System.Numerics;

namespace L9_AEVM1103526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int contadoropcion = 0;
            while (contadoropcion < 1)
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("Ingrese el número del problema al que quiera acceder:");
                Console.WriteLine("==============================================");
                Console.WriteLine("1. Parámetros por valor");
                Console.WriteLine("2. Parámetros por referencia");
                Console.WriteLine("3. Integración. Parámetros por valor y por referencia");
                Console.WriteLine("4. Videojuego");
                Console.WriteLine("5. Salir");
                Console.WriteLine("==============================================");
                int opción = int.Parse(Console.ReadLine());
                switch (opción)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ejercicio 1: Parámetros por valor");
                        Console.WriteLine("Ingrese una palabra de su elección");
                        string palabra = Console.ReadLine();
                        palabras(palabra);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingrese la primera variable");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la segunda variable");
                        int b = int.Parse(Console.ReadLine());

                        Console.WriteLine("A CONTINUACIÓN SE CAMBIARÁN LOS VALORES DE LAS VARIABLES");
                        Console.WriteLine("a = " + a);
                        Console.WriteLine("b = " + b);

                        invertir(ref a, ref b);
                        Console.WriteLine("INVIRTIENDO VALORES...");
                        Console.ReadLine();

                        Console.WriteLine("VALORES INVERTIDOS:");
                        Console.WriteLine("a = " + a);
                        Console.WriteLine("b = " + b);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        double total = 0;
                        double descuento = 0;
                        Console.WriteLine("BIENVENIDO/A A CINEPOLIS");
                        Console.WriteLine("Ingrese el precio del boleto");
                        double precioBoleto = double.Parse(Console.ReadLine());
                        Console.WriteLine("Precio del boleto: Q." + precioBoleto);
                        Console.WriteLine("Ingrese el número de boletos que desea comprar");
                        int cantidadBoletos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Seleccione el tipo de usuario");
                        Console.WriteLine("==============================================");
                        Console.WriteLine("1. Adulto Mayor");
                        Console.WriteLine("2. Niño");
                        Console.WriteLine("3. Cliente VIP");
                        Console.WriteLine("4. Ninguno de los anteriores");
                        Console.WriteLine("==============================================");
                        int tipoUsuario = int.Parse(Console.ReadLine());
                        if (tipoUsuario == 1)
                        {
                            descuento = 0.5;
                        }
                        else if (tipoUsuario == 2)
                        {
                            descuento = 0.15;
                        }
                        else if (tipoUsuario == 3)
                        {
                            descuento = 0.1;
                        }
                        else
                        {
                            descuento = 0;
                        }
                        total = totalDescuento(ref precioBoleto, descuento, cantidadBoletos);

                        Console.WriteLine("El precio total es de: Q." + total);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("======================C# QUEST========================");
                        Console.WriteLine("C# QUEST");
                        Console.WriteLine("Prepárate para la aventura...");
                        Console.WriteLine("Presiona ENTER para comenzar tu viaje...");
                        Console.ReadLine();
                        Console.Clear();


                        int salud = 15;

                        int contadorAccion = 0;
                        while (contadorAccion < 1)
                        {
                            Console.WriteLine("======================C# QUEST========================");
                            Console.WriteLine("SELECCIONA UNA ACCIÓN:");
                            Console.WriteLine("==============================================");
                            Console.WriteLine("1. Recibir daño");
                            Console.WriteLine("2. Curarse");
                            Console.WriteLine("3. Mostrar salud");
                            Console.WriteLine("4. Finalizar nivel");
                            Console.WriteLine("==============================================");
                            int acción = int.Parse(Console.ReadLine());
                            switch (acción)
                            {
                                case 1:
                                    Console.Clear();
                                    recibirdaño(ref salud);
                                    break;
                                case 2:
                                    Console.Clear();
                                    curarse(ref salud);
                                    break;
                                case 3:
                                    Console.Clear();
                                    mostrarsalud(salud);
                                    break;
                                case 4:
                                    Console.Clear();
                                    desempeno(salud);
                                    contadorAccion++;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("======================C# QUEST========================");
                                    Console.WriteLine("Acción no válida");
                                    Console.Clear();
                                    break;
                            }

                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Hasta la próxima ingeniero :)...");
                        Console.WriteLine("Presiona ENTER para finalizar...");
                        Console.ReadLine();
                        contadoropcion++;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Inválido...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }

            




        }

        //videojuego
        static void recibirdaño(ref int salud)
        {
            Console.WriteLine("======================C# QUEST========================");
            Console.WriteLine("Has perdido 5 puntos de vida...");

            salud = salud - 5;
            if (salud < 0)
            {
                Console.WriteLine(". . .");
                Console.ReadLine();
                salud = 0;
                Console.WriteLine("Tu salúd ha llegado a 0...");
                Console.WriteLine("Presion ENTER para ver tu destino...");
                Console.ReadLine();
                Console.WriteLine("Has muerto...");
            }
            Console.ReadLine();
            Console.Clear();
        }
        static void curarse(ref int salud)
        {
            Console.WriteLine("======================C# QUEST========================");
            if (salud == 0)
                {
                    Console.WriteLine("Has muerto...");
                } else if (salud > 12) {
                    Console.WriteLine("Has el máximo de vida...");
                    salud = 15;
            }
                else
                {
                    Console.WriteLine("Has ganado 3 puntos de vida...");
                    salud = salud + 3;
                }
            Console.ReadLine();
            Console.Clear();
        }
        static void mostrarsalud(int salud)
        {
            Console.WriteLine("======================C# QUEST========================");
            if ((salud > 10) && (salud < 16))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("La salud actual: " + salud);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Presion ENTER para ver tu continuar...");
                Console.ReadLine();
                Console.Clear();

            } else if ((salud > 5) && (salud < 11))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("La salud actual: " + salud);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Presion ENTER para ver tu continuar...");
                Console.ReadLine();
                Console.Clear();
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La salud actual: " + salud);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Presion ENTER para ver tu continuar...");
                Console.ReadLine();
                Console.Clear();

            }
        }

        static void desempeno(int salud)
        {
            Console.WriteLine("======================C# QUEST========================");
            if (salud == 15)
            {
                Console.WriteLine("Calificación: ¡S!");


            }
            else if ((salud < 15) && (salud > 10))
            {
                Console.WriteLine("Calificación: A");
            }
            else if ((salud < 11) && (salud > 5))
            {
                Console.WriteLine("Calificación: B");
            }
            else
            {
                Console.WriteLine("Calificación: C");
            }
            

        }
        static void palabras(string palabra)
        {
            int letras = 0;
            letras = palabra.Length;
            Console.WriteLine("La palabra tiene " + letras + " letras");
        }
        static int invertir(ref int a, ref int b)
        {
            int c = a;
            int d = b;
            a = d;
            b = c;
            return 0;
        }
        static double totalDescuento(ref double precio, double descuento, int cantidad)
        {
            double total = 0;
            precio = precio - (precio * descuento);
            total = precio * cantidad;


            return total;
            
        }
        
    }

}
