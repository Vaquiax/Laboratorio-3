//Problema #1 - Mostrar números del 1 al 20.
using static System.Runtime.InteropServices.JavaScript.JSType;

string nombre = "Andrés Eduardo Vaquiax Menéndez";
int carnet = 1103526;


Console.WriteLine("Nombre: " + nombre + "Carnet: " + carnet.ToString());
Console.WriteLine("Presione enter para comenzar...");
Console.ReadLine();
Console.WriteLine("==========================================================");
Console.WriteLine("Números del 1 al 20:");

int indice = 1;

while (indice <= 20)
{
    if (indice % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
    else
    {
        Console.ForegroundColor= ConsoleColor.Green;
    }

    Console.WriteLine(indice);
    indice++;
}

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("==========================================================");
Console.WriteLine("Presione enter para avanzar al siguiente ejercicio...");
Console.ReadLine();
Console.WriteLine("==========================================================");
Console.WriteLine("Divisores de un número");

Console.WriteLine("Ingrese un número entero postivo: ");
int numero = int.Parse(Console.ReadLine());
int contador = 1;


do
{
    if (numero % contador == 0)
        {
            Console.WriteLine(contador);

            
        }
    contador++;

} while (numero >= contador);


    Console.WriteLine("==========================================================");
    Console.WriteLine("Presione enter para avanzar al siguiente ejercicio...");
    Console.ReadLine();
    Console.WriteLine("==========================================================");
    Console.WriteLine("Serie de Fibonacci:");


    Console.WriteLine("Ingrese un número: ");
    int fibo = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    int a = 0;
    int b = 1;

    for (int i = 0; i < fibo; i++)
    {
        Console.WriteLine(a);
        int siguiente = a + b;
        a = b;
        b = siguiente;

    }


    Console.WriteLine("==========================================================");
    Console.WriteLine("Presione enter para avanzar al siguiente ejercicio...");
    Console.ReadLine();
    Console.WriteLine("==========================================================");
    Console.WriteLine("Tablas de multiplicar: ");


    int numero2 = 1;

    for (int i = 1; i <= 12; i++)
    {
        Console.WriteLine("Tabla del: " + i);


        while (numero2 <= 10)
        {
            Console.WriteLine(i + " x " + numero2 + " = " + (i * numero2));
            numero2++;
        }
        numero2 = 1;

    }

    Console.WriteLine("==========================================================");
Console.ReadLine();