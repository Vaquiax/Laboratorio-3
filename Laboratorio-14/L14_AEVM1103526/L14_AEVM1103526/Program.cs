namespace L14_AEVM1103526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=======================================");
            Console.WriteLine("Bienvenido al Laboratorio 14!");
            Console.WriteLine("Andrés Eduardo Vaquiax Menéndez");
            Console.WriteLine("1103526");

            Console.WriteLine("=======================================");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.Clear();
            int contadorGeneral = 0;

            while (contadorGeneral == 0)
            {

            Console.WriteLine("=======================================");
            Console.WriteLine("1. Ejercicio 1: Cuenta Bancaria");
            Console.WriteLine("2. Ejercicio 2: Productos en una tienda");
            Console.WriteLine("3. Ejercicio 3: Estudiantes");
            Console.WriteLine("4. Salir");
                Console.WriteLine("=======================================");

            Console.Write("Ingrese el número del Ejercicio que desea ejecutar (1-4): ");
            int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        CuentaBancaria cuenta = new CuentaBancaria("Luis Oliva", "39949258", 1000.00);
                        CuentaBancaria cuentados = new CuentaBancaria("Andrés Vaquiax", "42850710", 1000.00);
                        Console.WriteLine("=======================================");
                        Console.WriteLine("Cuentas bancarias creadas:");
                        Console.WriteLine("1. Luis Oliva - 39949258 - Q1000.00");
                        Console.WriteLine("2. Andrés Vaquiax - 42850710 - Q1000.00");
                        Console.WriteLine("=======================================");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();

                        Console.WriteLine("=======================================");
                        Console.WriteLine("Ingrese el número de cuenta a consultar:");
                        Console.WriteLine("=======================================");
                        int numeroCuentaSwitch = int.Parse(Console.ReadLine());

                        Console.Clear();
                        int contadorEjUno = 0;

                        while (contadorEjUno == 0)
                        {
                            Console.WriteLine("=======================================");
                            Console.WriteLine("Elija una opción:");
                            Console.WriteLine("1. Mostrar información de la cuenta");
                            Console.WriteLine("2. Retirar dinero");
                            Console.WriteLine("3. Depositar dinero");
                            Console.WriteLine("4. Salir");
                            Console.WriteLine("=======================================");
                            int subOpcion = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (numeroCuentaSwitch)
                            {
                                case 39949258:
                                    switch (subOpcion)
                                    {
                                        case 1:
                                            Console.WriteLine("=======================================");
                                            cuenta.MostrarInformacion();
                                            Console.WriteLine("=======================================");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Presione ENTER para continuar...");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        case 2:
                                            Console.WriteLine("=======================================");
                                            Console.WriteLine("Ingrese la cantidad a retirar:");
                                            double cantidadRetirar = double.Parse(Console.ReadLine());
                                            cuenta.Retirar(cantidadRetirar);
                                            Console.WriteLine("=======================================");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Presione ENTER para continuar...");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        case 3:
                                            Console.WriteLine("=======================================");
                                            Console.WriteLine("Ingrese la cantidad a depositar:");
                                            double cantidadDepositar = double.Parse(Console.ReadLine());
                                            cuenta.Depositar(cantidadDepositar);
                                            Console.WriteLine("=======================================");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Presione ENTER para continuar...");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        case 4:
                                            Console.WriteLine("=======================================");
                                            Console.WriteLine("Regresando al menú principal...");
                                            Console.WriteLine("=======================================");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Presione ENTER para continuar...");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadLine();
                                            Console.Clear();
                                            contadorEjUno++;
                                            break;
                                    }
                                    break;
                                case 42850710:
                                    switch (subOpcion)
                                    {
                                        case 1:
                                            Console.WriteLine("=======================================");
                                            cuentados.MostrarInformacion();
                                            Console.WriteLine("=======================================");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Presione ENTER para continuar...");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        case 2:
                                            Console.WriteLine("=======================================");
                                            Console.WriteLine("Ingrese la cantidad a retirar:");
                                            double cantidadRetirar = double.Parse(Console.ReadLine());
                                            cuentados.Retirar(cantidadRetirar);
                                            Console.WriteLine("=======================================");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Presione ENTER para continuar...");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        case 3:
                                            Console.WriteLine("=======================================");
                                            Console.WriteLine("Ingrese la cantidad a depositar:");
                                            double cantidadDepositar = double.Parse(Console.ReadLine());
                                            cuentados.Depositar(cantidadDepositar);
                                            Console.WriteLine("=======================================");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Presione ENTER para continuar...");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        case 4:
                                            Console.WriteLine("=======================================");
                                            Console.WriteLine("Regresando al menú principal...");
                                            Console.WriteLine("=======================================");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Presione ENTER para continuar...");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadLine();
                                            Console.Clear();
                                            contadorEjUno++;
                                            break;
                                    }
                                    break;
                                
                                default:
                                    Console.WriteLine("Número de cuenta no encontrado.");
                                    Console.Clear();
                                    return;

                            }
                        }
                        break;
                        case 2:
                         Producto Alfajores = new Producto("Alfajores", "Q15.00", 50);
                         Producto Nachos = new Producto("Nachos", "Q25.00", 30);
                        Console.Clear();
                        Console.WriteLine("=======================================");
                        Console.WriteLine("Productos disponibles:");
                        Alfajores.MostrarInformacion();
                        Console.WriteLine("=======================================");
                        Nachos.MostrarInformacion();
                        Console.WriteLine("=======================================");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        Console.Clear();

                        int contadorEjDosGeneral = 0;

                        while (contadorEjDosGeneral == 0)
                        {

                            Console.WriteLine("=======================================");
                            Console.WriteLine("Elija un producto a modificar");
                            Console.WriteLine("1. Alfajores");
                            Console.WriteLine("2. Nachos");
                            Console.WriteLine("3. Salir");
                            Console.WriteLine("=======================================");
                            int productoSeleccionado = int.Parse(Console.ReadLine());

                            int contadorEjDos = 0;

                            if (productoSeleccionado == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("=======================================");
                                Console.WriteLine("Saliendo del Ejemplo 2...");
                                Console.WriteLine("=======================================");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("Presione ENTER para continuar...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadLine();
                                contadorEjDosGeneral++;
                                contadorEjDos++;
                            }

                            while (contadorEjDos == 0)
                            {

                                Console.Clear();
                                Console.WriteLine("=======================================");
                                Console.WriteLine("Elija una opción:");
                                Console.WriteLine("1. Mostrar información del producto");
                                Console.WriteLine("2. Vender producto");
                                Console.WriteLine("3. Reabastecer producto");
                                Console.WriteLine("4. Salir/Elegir Otro Producto");
                                Console.WriteLine("=======================================");
                                int opcionProducto = int.Parse(Console.ReadLine());

                                switch (productoSeleccionado)
                                {
                                    case 1:

                                        switch (opcionProducto)
                                        {
                                            case 1:
                                                Console.Clear();
                                                Console.WriteLine("=======================================");
                                                Alfajores.MostrarInformacion();
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine("=======================================");
                                                Console.WriteLine("Ingrese la cantidad a vender:");
                                                int cantidadVender = int.Parse(Console.ReadLine());
                                                Alfajores.Vender(cantidadVender);
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 3:
                                                Console.Clear();
                                                Console.WriteLine("=======================================");
                                                Console.WriteLine("Ingrese la cantidad a reabastecer:");
                                                int cantidadReabastecer = int.Parse(Console.ReadLine());
                                                Alfajores.Reabastecer(cantidadReabastecer);
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 4:
                                                Console.Clear();
                                                Console.WriteLine("=======================================");
                                                Console.WriteLine("Regresando al menú...");
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                contadorEjDos++;
                                                break;
                                        }


                                        break;
                                    case 2:
                                        switch (opcionProducto)
                                        {
                                            case 1:
                                                Console.Clear();
                                                Console.WriteLine("=======================================");
                                                Nachos.MostrarInformacion();
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine("=======================================");
                                                Console.WriteLine("Ingrese la cantidad a vender:");
                                                int cantidadVender = int.Parse(Console.ReadLine());
                                                Nachos.Vender(cantidadVender);
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 3:
                                                Console.Clear();
                                                Console.WriteLine("=======================================");
                                                Console.WriteLine("Ingrese la cantidad a reabastecer:");
                                                int cantidadReabastecer = int.Parse(Console.ReadLine());
                                                Nachos.Reabastecer(cantidadReabastecer);
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 4:
                                                Console.Clear();
                                                Console.WriteLine("=======================================");
                                                Console.WriteLine("Regresando al menú principal...");
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                contadorEjDos++;
                                                Console.Clear();
                                                break;
                                        }
                                        break;
                                    
                                }

                            }
                        }
                        break;
                    case 3:
                        Estudiante Julian = new Estudiante("Julian", 20, "10° grado", new double[] { 85.5, 90.0, 78.0 });
                        Estudiante Andres = new Estudiante("Andrés", 19, "11° grado", new double[] { 92.0, 88.5, 95.0 });


                        int contadorEjTresGeneral = 0;
                        while (contadorEjTresGeneral == 0)

                        {
                            Console.Clear();
                            Console.WriteLine("=======================================");
                            Console.WriteLine("Estudiantes:");
                            Console.WriteLine("1. Julian - 20 años - 10° grado");
                            Console.WriteLine("2. Andrés - 19 años - 11° grado");
                            Console.WriteLine("3. Salir");
                            Console.WriteLine("=======================================");
                            Console.WriteLine("Seleccione un estudiante para modificar su información:");
                            int estudianteSeleccionado = int.Parse(Console.ReadLine());
                            int contadorEjTres = 0;

                            if (estudianteSeleccionado == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("=======================================");
                                Console.WriteLine("Saliendo del Ejemplo 3...");
                                Console.WriteLine("=======================================");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("Presione ENTER para continuar...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadLine();
                                contadorEjTresGeneral++;
                                contadorEjTres++;
                            }

                            while (contadorEjTres == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("=======================================");
                                Console.WriteLine("Elija una opción:");
                                Console.WriteLine("1. Mostrar información del estudiante");
                                Console.WriteLine("2. Calcular promedio de notas");
                                Console.WriteLine("3. Agregar nueva nota");
                                Console.WriteLine("4. Salir/Cambiar alumno");
                                Console.WriteLine("=======================================");
                                int opcionEstudiante = int.Parse(Console.ReadLine());

                                switch (estudianteSeleccionado)
                                {
                                    case 1:
                                        switch (opcionEstudiante)
                                        {
                                            case 1:
                                                Console.Clear();
                                                Console.WriteLine("=======================================");
                                                Julian.MostrarInformacion();
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 2:
                                                Console.WriteLine("=======================================");
                                                Julian.CalcularPromedio();
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 3:
                                                Console.WriteLine("=======================================");
                                                Console.WriteLine("Ingrese la nueva nota:");
                                                double nuevaNota = double.Parse(Console.ReadLine());
                                                Julian.agregarNota(nuevaNota);
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                                case 4:
                                                Console.WriteLine("=======================================");
                                                Console.WriteLine("Regresando al menú principal...");
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                contadorEjTres++;
                                                break;
                                        }
                                        break;
                                            case 2:
                                        switch (opcionEstudiante)
                                        {
                                            case 1:
                                                Console.Clear();
                                                Console.WriteLine("=======================================");
                                                Andres.MostrarInformacion();
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 2:
                                                Console.WriteLine("=======================================");
                                                Andres.CalcularPromedio();
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 3:
                                                Console.WriteLine("=======================================");
                                                Console.WriteLine("Ingrese la nueva nota:");
                                                double nuevaNota = double.Parse(Console.ReadLine());
                                                Andres.agregarNota(nuevaNota);
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 4:
                                                Console.WriteLine("=======================================");
                                                Console.WriteLine("Regresando al menú principal...");
                                                Console.WriteLine("=======================================");
                                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                                Console.WriteLine("Presione ENTER para continuar...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();
                                                Console.Clear();
                                                contadorEjTres++;
                                                break;
                                        }
                                        break;
                                            default:
                                                Console.WriteLine("Opción no válida.");
                                                break;
                                        }
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("=======================================");
                            Console.WriteLine("Saliendo del programa...");
                            Console.WriteLine("Nos vemos a la próxima!");
                            Console.WriteLine("=======================================");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                            contadorGeneral++;
                            break;


                }
            }
        }
    }
}
