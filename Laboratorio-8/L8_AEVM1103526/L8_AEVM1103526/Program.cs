

using System.ComponentModel.Design;

int contadormenu = 0;

while (contadormenu < 1)
{
    Console.WriteLine("Bienvenido al programa del laboratorio #8");
    Console.WriteLine("==================================================");
    Console.WriteLine("Ingrese el número del ejercicio al que quiera ingresar");
    Console.WriteLine("==================================================");
    Console.WriteLine("1. Ejercicio #1 (20 números)");
    Console.WriteLine("");
    Console.WriteLine("2. Ejercicio #2 (números del 1 al 100)");
    Console.WriteLine("");
    Console.WriteLine("3. Ejercicio #3 (compras 10 clientes)");
    Console.WriteLine("");
    Console.WriteLine("4. Ejercicio #4 (Elejir una opción para un número ingresado)");
    Console.WriteLine("");
    Console.WriteLine("5. Ejercicio #5 (Triángulo de asteriscos)");
    Console.WriteLine("");
    Console.WriteLine("6. SALIR");
    Console.WriteLine("==================================================");
    int ejercicio = int.Parse(Console.ReadLine()!);

    switch (ejercicio)
    {
        case 1:
            //Ejercicio #1 Realice un programa que permita solicitar 20 números al usuario
            Console.Clear();
            Console.WriteLine("Ejercicio #1");
            Console.WriteLine("==================================================");
            int count = 0;
            int numeromayor = 0;
            int numeromenor = 0;
            int suma = 0;
            int promedio = 0;

            Console.WriteLine("Ingrese un número");
            int numero = int.Parse(Console.ReadLine());
            Console.Clear();

            numeromayor = numero;
            numeromenor = numero;


            while (count < 19)
            {
                Console.WriteLine("Numero a ingresar: " + (count + 2));
                Console.WriteLine("==================================================");
                Console.WriteLine("Ingrese otro número");
                int numero2 = int.Parse(Console.ReadLine());

                suma = numero2 + suma;


                if (numero2 > numeromayor)
                {
                    numeromayor = numero2;
                }

                if (numero2 < numeromenor)
                {
                    numeromenor = numero2;
                }


                Console.Clear();
                count++;

            }

            suma = suma + numero;
            promedio = suma / 20;

            Console.WriteLine("==================================================");
            Console.WriteLine("El número mayor es: " + numeromayor);
            Console.WriteLine("El número menor es: " + numeromenor);
            Console.WriteLine("La suma de los números es: " + suma);
            Console.WriteLine("El promedio de los números es: " + promedio);
            Console.WriteLine("==================================================");
            Console.ReadLine();
            Console.Clear();
            break;
        case 2:
            Console.WriteLine("Ejercicio #2");
            Console.WriteLine("==================================================");
            int num = 1;
            while (num <= 100)
            {
                Console.Write(num);
                if ((num % 2 == 0) & (num % 7 == 0))
                {
                    Console.Write(" ParSiete");

                }
                else if (num % 7 == 0)
                {
                    Console.Write(" Siete");

                }
                else if (num % 2 == 0)
                {
                    Console.Write(" Par");

                }
                Console.WriteLine("");


                num++;
            }
            Console.WriteLine("==================================================");
            Console.ReadLine();
            Console.Clear();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Ejercicio #3");
            Console.WriteLine("==================================================");
            int totaldescuentos = 0;
            double totalventas = 0;
            int cliente = 0;


            while (cliente < 10)
            {
                bool descuentodoce = false;
                bool descuentocinco = false;


                Console.WriteLine("Ingrese el nombre del cliente:");
                string nombrecliente = Console.ReadLine();
                Console.WriteLine("Ingrese el total de la compra");
                double totalcompra = int.Parse(Console.ReadLine());

                if ((totalcompra >= 300) & (totalcompra < 700))
                {
                    totalcompra = totalcompra - (totalcompra * 0.05);
                    totaldescuentos++;
                    totalventas = totalventas + totalcompra;
                    descuentocinco = true;
                    totaldescuentos++;
                    cliente++;

                }
                else if (totalcompra >= 700)
                {
                    totalcompra = totalcompra - (totalcompra * 0.12);
                    totaldescuentos++;
                    totalventas = totalventas + totalcompra;
                    descuentodoce = true;
                    totaldescuentos++;
                    cliente++;

                }
                else if ((totalcompra < 300) & (totalcompra > 0))
                {
                    totalventas = totalventas + totalcompra;
                    cliente++;
                }
                else
                {
                    Console.WriteLine("Total de compra no válido");
                }
                Console.WriteLine(nombrecliente + " ha pagado: " + totalcompra);

                if (descuentocinco == true)
                {
                    Console.WriteLine("Descuento aplicado: 5%");
                }
                else if (descuentodoce == true)
                {
                    Console.WriteLine("Descuento aplicado: 12%");
                }
                else
                {
                    Console.WriteLine("No se aplicó ningún descuento");
                }


                Console.WriteLine("==================================================");
                Console.ReadLine();



            }

            Console.WriteLine("Total de ventas del día: " + totalventas);
            Console.WriteLine("Descuentos aplicados: " + totaldescuentos);
            Console.WriteLine("==================================================");
            Console.ReadLine();
            Console.Clear();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Ejercicio #4");
            Console.WriteLine("==================================================");
            Console.WriteLine("Ingrese un número");
            int numeroingresado = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese una opción del 1 al 3");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Mostrar los números desde el " + numeroingresado + " hasta el 1");
            Console.WriteLine("");
            Console.WriteLine("2. Mostrar los múltiplos de 3 hasta el " + numeroingresado);
            Console.WriteLine("");
            Console.WriteLine("3. Mostrar los múltiplos de 5 hasta el " + numeroingresado);
            Console.WriteLine("==================================================");
            int opcionej = int.Parse(Console.ReadLine());
            switch (opcionej)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Números desde el " + numeroingresado + " hasta el 1");
                    Console.WriteLine("==================================================");
                    int limite;
                    limite = numeroingresado;
                    if (numeroingresado > 0)
                    

                    {
                        for (int i = 0; i < numeroingresado; i++)
                        {
                            
                            Console.WriteLine(numeroingresado-i);

                        }

                    }
                    else if (numeroingresado < 1)
                    {
                        while (limite <= 1)
                        {
                            Console.WriteLine(limite);
                            limite++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número ingresado es 1");
                    }
                    Console.WriteLine("==================================================");
                    Console.WriteLine("Presione ENTER para regresar");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Múltiplos de 3 hasta el " + numeroingresado);
                    Console.WriteLine("==================================================");
                    
                    
                    int limite2;
                    limite2 = 0;
                    
                    if (numeroingresado > 1)


                    {
                        for (int i = 0; i < numeroingresado; i++)
                        {
                            if ((numeroingresado - i) % 3 == 0)
                            {
                                Console.WriteLine(i);
                            }
                                

                        }

                    }
                    else if (numeroingresado < 0)
                    {
                        while (limite2 >= numeroingresado)
                        {
                            if (limite2 % 3 == 0)
                            {
                                Console.WriteLine(limite2);
                            }
                            limite2--;
                        }
                    }
                    
                    Console.WriteLine("==================================================");
                    Console.WriteLine("Presione ENTER para regresar");
                    Console.ReadLine();
                    Console.Clear();

                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Múltiplos de 5 hasta el número ingresado");
                    Console.WriteLine("==================================================");
                    int limite3;
                    limite3 = 0;

                    if (numeroingresado > 1)


                    {
                        for (int i = 0; i < numeroingresado; i++)
                        {
                            if ((numeroingresado - i) % 5 == 0)
                            {
                                Console.WriteLine(i);
                            }


                        }

                    }
                    else if (numeroingresado < 0)
                    {
                        while (limite3 >= numeroingresado)
                        {
                            if (limite3 % 5 == 0)
                            {
                                Console.WriteLine(limite3);
                            }
                            limite3--;
                        }
                    }

                    Console.WriteLine("==================================================");
                    Console.WriteLine("Presione ENTER para regresar");
                    Console.ReadLine();
                    


                    Console.Clear();
                    break;
                
            }

            Console.Clear();
            break;
                

            case 5:
            Console.Clear();
            Console.WriteLine("Ejercicio #5");
            Console.WriteLine("==================================================");
            Console.WriteLine("Ingrese la altura del triángulo de asteriscos");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine("==================================================");
            for (int i = 1; i <= altura; i++)
            {
                

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("==================================================");
            Console.WriteLine("Presione ENTER para regresar");
            Console.ReadLine();










            Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Gracias por revisar el laboratorio #8");
                    Console.WriteLine("Andrés Vaquiax ;) - 1103526");
                    Console.WriteLine("Presione ENTER para salir...");
                    Console.ReadLine();
                    contadormenu++;
                    break;
                default:
                    Console.WriteLine("Número de ejercicio no válido");
                    break;

            }






    }
   


