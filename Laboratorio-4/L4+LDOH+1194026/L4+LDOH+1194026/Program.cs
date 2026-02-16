using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        //1. EJERCICIO 1: EL PERFIL DE UN PERSONAJE
        Console.WriteLine("EJERCICIO 1");
        string nombre = "bananin";
        int nivel = 7;
        float puntos_de_vida = 70.5f;
        bool es_un_jefe = false;
        Console.WriteLine(nombre + " " + nivel + " " + puntos_de_vida + " " + es_un_jefe);
        Console.ReadLine();

        //EJERCICIO 2: CONVERSION IMPLICITA
        Console.WriteLine("EJERCICIO 2");
        int numeroEntero = 1500;
        long numeroLargo;
        numeroLargo = numeroEntero;
        Console.WriteLine(numeroLargo);
        double numeroDecimal;
        numeroDecimal = numeroLargo;
        Console.WriteLine(numeroDecimal);
        Console.ReadLine();

        //EJERCICIO 3: Casting Explícito (Pérdida de precisión)
        Console.WriteLine("EJERCICIO 3");
        double precioExacto = 45.89;
        int precioRedondeado;
        precioRedondeado = (int)precioExacto;
        Console.WriteLine(precioRedondeado);
        Console.WriteLine(precioExacto);
        Console.ReadLine();
        //los deciamles del precio redondo se desaparecen, solo queda el 45 ya que se busca a numero entero pero no se aproxima.

        //EJERCICIO 4: DE TEXTO A NUMERO PARSE
        Console.WriteLine("EJERCICO 4");
        int numero;
        Console.WriteLine("Ingresa un numero: ");
        /*numero = Console.ReadLine();
        no returna error ya que lo que ingreso el usuario es texto y se esta guardando en una variable de tipo entero*/
        string entradaUsuario = Console.ReadLine();
        numero = int.Parse(entradaUsuario);
        numero = numero + 5;
        Console.WriteLine(numero);
        Console.ReadLine();

        //EJERCICIO 5: CLAVE CONVERT
        Console.WriteLine("EJERICICIO 5");
        string valorTexto = "true";
        bool valorBooleano = Convert.ToBoolean(valorTexto);
        string valorDecimal = "25,5";
        double valorDouble = Convert.ToDouble(valorDecimal);
        Console.WriteLine(valorBooleano);
        Console.WriteLine(valorDecimal);
        Console.ReadLine();

        //EJERCICIO 6: CONVERSION A TEXTO
        Console.WriteLine("EJERCICIO 6");
        double pi = 3.14159265;
        string cadena = pi.ToString();
        Console.WriteLine(cadena);
        string dosDecimales = pi.ToString("F2");
        Console.WriteLine(dosDecimales);
        Console.ReadLine();

        //EJERCICIO 7: CALCULADORA DE IVA
        Console.WriteLine("EJERCICIO 7");
        Console.WriteLine("dime el precio del producto");
        string producto = Console.ReadLine();
        double precioProducto = Convert.ToDouble(producto);
        double iva = precioProducto * 0.21;
        double total = iva + precioProducto;
        double totalInt = Convert.ToInt64(total);
        Console.WriteLine("El total a pagar es: " + totalInt);
    }
}