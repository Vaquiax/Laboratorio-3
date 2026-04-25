namespace L12_AEVM1103626
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=====================================");
            Console.WriteLine("Laboratorio #12");
            Console.WriteLine("Bienvenido...");
            Console.WriteLine("=====================================");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;



            int contadormenu = 0;
            while (contadormenu == 0)
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 3");
                Console.WriteLine("4. Ejercicio 4");
                Console.WriteLine("5. Salir");
                Console.WriteLine("=====================================");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Ingrese el número del ejercicio al que desea continuar...");
                Console.ForegroundColor = ConsoleColor.White;
                int menuseleccion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menuseleccion)
                {
                    case 1:
                        int suma = 0;
                        int numero = 0;
                        Console.WriteLine("=====================================");
                        Console.WriteLine("Ejercicio 1");
                        Console.WriteLine("Matriz 5x5");
                        Console.WriteLine("=====================================");


                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        int[,] matriz = new int[5, 5];
                        Console.Clear();
                        Console.WriteLine("De qué manera desea llenar la matriz?");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("1. Manualmente");
                        Console.WriteLine("2. Automáticamente");
                        Console.WriteLine("=====================================");
                        int llenarmatriz = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("=====================================");
                        switch (llenarmatriz)
                        {
                            case 1:
                                Console.WriteLine("Ingrese los números de la matriz: ");
                                for (int i = 0; i < matriz.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matriz.GetLength(1); j++)
                                    {
                                        Console.WriteLine("Posición [" + i + ", " + j + "]: ");

                                        matriz[i, j] = llenarmanual();

                                    }
                                }
                                break;
                            case 2:


                                for (int i = 0; i < matriz.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matriz.GetLength(1); j++)
                                    {


                                        matriz[i, j] = llenar();

                                    }
                                }
                                break;

                        }
                        Console.WriteLine("=====================================");
                        Console.Clear();



                        for (int i = 0; i < matriz.GetLength(0); i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            for (int j = 0; j < matriz.GetLength(1); j++)
                            {

                                Console.Write(matriz[i, j] + "\t");
                            }
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        sumaDiagonalPrincipal(matriz, ref suma);

                        sumaDiagonalSecundaria(matriz, ref numero);

                        Console.WriteLine("La suma de la diagonal principal es: " + suma);
                        Console.WriteLine("La suma de la diagonal secundaria es: " + numero);
                        Console.WriteLine("=====================================");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                    case 2:
                        Console.WriteLine("=====================================");
                        Console.WriteLine("Ejercicio 2");
                        Console.WriteLine("Matriz 4x6");
                        Console.WriteLine("=====================================");


                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();


                        Console.WriteLine("=====================================");
                        int[,] matrizdos = new int[4, 6];

                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("De qué manera desea llenar la matriz?");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("1. Manualmente");
                        Console.WriteLine("2. Automáticamente");
                        Console.WriteLine("=====================================");
                        int llenarmatrizdos = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("=====================================");
                        switch (llenarmatrizdos)
                        {
                            case 1:
                                Console.WriteLine("Ingrese los números de la matriz: ");
                                for (int i = 0; i < matrizdos.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matrizdos.GetLength(1); j++)
                                    {
                                        Console.WriteLine("Posición [" + i + ", " + j + "]: ");

                                        matrizdos[i, j] = llenarmanual();
                                    }
                                }
                                break;
                            case 2:


                                for (int i = 0; i < matrizdos.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matrizdos.GetLength(1); j++)
                                    {


                                        matrizdos[i, j] = llenar();

                                    }
                                }
                                break;

                        }
                        Console.WriteLine("=====================================");
                        Console.Clear();

                        for (int i = 0; i < matrizdos.GetLength(0); i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            for (int j = 0; j < matrizdos.GetLength(1); j++)
                            {

                                Console.Write(matrizdos[i, j] + "\t");
                            }
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        numerospares(matrizdos);

                        numerosimpares(matrizdos);
                        Console.WriteLine("=====================================");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();

                        break;
                    case 3:

                        Console.WriteLine("=====================================");
                        Console.WriteLine("Ejercicio 3");
                        Console.WriteLine("Matriz: Estudiantes (5), Notas (4)");
                        Console.WriteLine("=====================================");


                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();

                        int[,] matrizestudiantes = new int[5, 4];
                        Console.Clear();
                        Console.WriteLine("De qué manera desea llenar la matriz?");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("1. Manualmente");
                        Console.WriteLine("2. Automáticamente");
                        Console.WriteLine("=====================================");
                        int llenarmatritres = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("=====================================");
                        switch (llenarmatritres)
                        {
                            case 1:
                                Console.WriteLine("Ingrese los números de la matriz: ");
                                for (int i = 0; i < matrizestudiantes.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matrizestudiantes.GetLength(1); j++)
                                    {
                                        Console.WriteLine("Posición [" + i + ", " + j + "]: ");

                                        matrizestudiantes[i, j] = llenarmanual();
                                    }
                                }
                                break;
                            case 2:


                                for (int i = 0; i < matrizestudiantes.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matrizestudiantes.GetLength(1); j++)
                                    {


                                        matrizestudiantes[i, j] = llenar();
                                    }
                                }
                                break;

                        }
                        Console.WriteLine("=====================================");
                        Console.Clear();
                        Console.WriteLine("=====================================");
                        for (int i = 0; i < matrizestudiantes.GetLength(0); i++)
                        {
                            Console.Write("Estudiante " + (i + 1) + ": ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            for (int j = 0; j < matrizestudiantes.GetLength(1); j++)
                            {
                                Console.Write($"{matrizestudiantes[i, j],4}    ");
                            }
                            promedio(matrizestudiantes, i);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }




                        Console.WriteLine("=====================================");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 4:

                        Console.WriteLine("=====================================");
                        Console.WriteLine("Ejercicio 4");
                        Console.WriteLine("Matriz 3x3");
                        Console.WriteLine("=====================================");


                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();

                        int[,] matrizcuatro = new int[3, 3];

                        Console.Clear();
                        Console.WriteLine("De qué manera desea llenar la matriz?");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("1. Manualmente");
                        Console.WriteLine("2. Automáticamente");
                        Console.WriteLine("=====================================");
                        int llenarmatrizcuatro = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("=====================================");
                        switch (llenarmatrizcuatro)
                        {
                            case 1:
                                Console.WriteLine("Ingrese los números de la matriz: ");
                                for (int i = 0; i < matrizcuatro.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matrizcuatro.GetLength(1); j++)
                                    {
                                        Console.WriteLine("Posición [" + i + ", " + j + "]: ");

                                        matrizcuatro[i, j] = llenarmanual();
                                    }
                                }
                                break;
                            case 2:


                                for (int i = 0; i < matrizcuatro.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matrizcuatro.GetLength(1); j++)
                                    {


                                        matrizcuatro[i, j] = llenar();
                                    }
                                }
                                break;

                        }
                        Console.Clear();

                        for (int i = 0; i < matrizcuatro.GetLength(0); i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            for (int j = 0; j < matrizcuatro.GetLength(1); j++)
                            {
                                Console.Write(matrizcuatro[i, j] + "\t");
                            }
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        simetriaejey(matrizcuatro);
                        Console.WriteLine("=====================================");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 5:
                        Console.WriteLine("¿Desea salir?");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("1. Sí");
                        Console.WriteLine("2. No");
                        Console.WriteLine("=====================================");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        int salir = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;
                        switch (salir)
                        {
                            case 1:
                                Console.WriteLine("Nos vemos ingeniero...");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("Presione ENTER para salir...");
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                contadormenu++;
                                break;
                            case 2:

                                break;


                            default:
                                Console.WriteLine("Opción no válida");
                                break;
                        }
                                break;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        static int llenar()
        {
            Random random = new Random();
            return random.Next(1, 101);

        }
        static int llenarmanual()
        {
            int numero = int.Parse(Console.ReadLine());
            return numero;

        }
        static void sumaDiagonalPrincipal(int[,] matriz, ref int suma)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                suma = suma + matriz[i, i];
            }
        }

        static void sumaDiagonalSecundaria(int[,] matriz, ref int numero)

        {
            int j = matriz.GetLength(1) - 1;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                numero = numero + matriz[i, j];
                j--;
            }
        }

        static void numerospares(int[,] matriz)
        {
            int pares = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        pares++;
                    }
                }
            }
            Console.WriteLine("En la matriz existen: " + pares + " numeros pares.");

        }

        static void numerosimpares(int[,] matriz)
        {
            int impares = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] % 2 != 0)
                    {
                        impares++;
                    }
                }
            }
            Console.WriteLine("En la matriz existen: " + impares + " numeros impares.");
            Console.WriteLine();
        }

        static void promedio(int[,] matriz, int estudiante)
        {
            int prom = 0;
            int suma = 0;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                suma = suma + matriz[estudiante, j];
            }
            prom = suma / matriz.GetLength(1);
            Console.Write("Promedio: " + prom);
            if (prom >= 61)
            {
                Console.Write("\t" + "Aprobado.");
            }
            else
            {
                Console.Write("\t" + "Reprobado.");
            }
        }

        static void simetriaejey(int[,] matriz)
        {
            bool esSimetrica = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3 / 2; j++)
                {
                    if (matriz[i, j] != matriz[i, 2 - j])
                    {
                        esSimetrica = false;
                        break;
                    }
                }

                if (!esSimetrica)
                    break;
            }

            if (esSimetrica)
                Console.WriteLine("La matriz es simétrica respecto al eje Y.");
            else
                Console.WriteLine("La matriz no es simétrica respecto al eje Y.");


        }
    }
}
