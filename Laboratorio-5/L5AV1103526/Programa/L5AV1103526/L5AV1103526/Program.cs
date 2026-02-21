//Desafío #1 Estructuras selectivas
using System.Net;

Console.WriteLine("=================================================");
Console.WriteLine("Desafío #1 Estructuras selectivas");
Console.WriteLine("=================================================");
Console.WriteLine("");
Console.WriteLine("Ingrese un número");
int numero = Convert.ToInt32(Console.ReadLine());
if (numero > 0)
{
   Console.WriteLine("El número " + numero + " es positivo");
}
else if (numero < 0) 
{
    Console.WriteLine("El número " + numero +  " es negativo"); 
}
else 
{
    Console.WriteLine("El número es cero");

}

Console.WriteLine("");
Console.WriteLine("=================================================");


//Desafío #2 Estructuras selectivas
Console.WriteLine("Desafío #2 Estructuras selectivas");
Console.WriteLine("=================================================");
Console.WriteLine("");
Console.WriteLine("A CONTINUACIÓN: Se analizará si el año ingresado es bisiesto");
Console.WriteLine("Ingrese un año");
int año = Convert.ToInt32(Console.ReadLine());
if (((año % 4 == 0) && (año % 100 != 0))) {
    Console.WriteLine("El año " + año + " es bisiesto");

}
else if ((año % 400 == 0))
{
    Console.WriteLine("El año " + año + " es bisiesto");
}
else
{
    Console.WriteLine("El año " + año + " no es bisiesto");
}

Console.WriteLine("");
Console.WriteLine("=================================================");
//Desafío #3 Estructuras selectivas
Console.WriteLine("Desafío #3 Estructuras selectivas");
Console.WriteLine("=================================================");
Console.WriteLine("");

double Cuotapago = 0;
double Total = 0;
double Diferenciamulta = 0;



Console.WriteLine("BUENOS DÍAS VECINO");
Console.WriteLine("Para determinar su boleto de ornato, porfavor ingrese su salario mensual");
double salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("¿Está usted atrasado con el pago?");
Console.WriteLine(" ");
Console.WriteLine("ESCRIBA EN LA CONSOLA");
Console.WriteLine(" ");
Console.WriteLine("'1': No");
Console.WriteLine(" ");
Console.WriteLine("'2': Sí");

bool multa = false;

int opcion = Convert.ToInt32(Console.ReadLine());


switch (opcion)
{

    case 1:
        {
            multa = false;
            break;
        }
    case 2:
        {
            multa = true;
            break;
        }
    default:
        {
            Console.WriteLine("Opción no válida, se asumirá que no tiene multa");
            multa = false;
            break;
        }
}

Console.WriteLine(salario);
if ((salario > 500) && (salario <= 1000))
{

    Cuotapago = 10;

    if (multa == true)
    {
        Total = Cuotapago + 20;
    }
    else if (multa == false)
    {
        Total = Cuotapago;

    }
}
else if ((salario > 1000) && (salario <= 3000))
{
    Cuotapago = 15;
    if (multa == true)
    {
        Total = Cuotapago + 30;
    }
    else if (multa == false)
    {
        Total = Cuotapago;
    }
} else if ((salario > 3000) && ((salario <=6000)))
{
    Cuotapago = 50;
    if (multa == true)
    {
        Total = Cuotapago + 100;
    }
    else if (multa == false)
    {
        Total = Cuotapago;
    }
} else if ((salario > 6000) && ((salario <= 9000)))
{
    Cuotapago = 75;
    if (multa == true)
    {
        Total = Cuotapago + 150;
    }
    else if (multa == false)
    {
        Total = Cuotapago;
    }
} else if ((salario > 9000) && (salario <= 12000)) {

    Cuotapago = 100;
    if (multa == true)
    {
        Total = Cuotapago + 200;
    }
    else if (multa == false)
    {
        Total = Cuotapago;
    }
} else if   (salario > 12000)
{
    Cuotapago = 150;
    if (multa == true)
    {
        Total = Cuotapago + 300;
    }
    else if (multa == false)
    {
        Total = Cuotapago;
    }
} else
{
    Console.WriteLine("El salario ingresado no es válido");
    
}
Diferenciamulta = Total-Cuotapago;

if (multa == false) { 
Console.WriteLine("Su cuota de pago es: " + Total);
}

if (multa == true) {
    Console.WriteLine("Su cuota de pago (Sin la multa incluida) es: " + Cuotapago);
    Console.WriteLine("La multa a pagar es: " + Diferenciamulta);
    Console.WriteLine("Su cuota de pago total es: " + Total);

}

Console.WriteLine("");
Console.WriteLine("=================================================");
//Desafío #3 Estructuras selectivas
Console.WriteLine("Desafío #3 Estructuras selectivas");
Console.WriteLine("=================================================");
Console.WriteLine("");

int Totalapagar = 0;


Console.WriteLine("------------------OKLAND MALL--------------------");
Console.WriteLine("                 pago de parueo");
Console.WriteLine("");
Console.WriteLine("Ingrese el número de horas que ha estado estacionado");
int horas = Convert.ToInt32(Console.ReadLine());
Totalapagar = horas * 10;
Console.WriteLine("El total a pagar por " + horas + " horas de estacionamiento es: Q." + Totalapagar);
Console.WriteLine("Por favor, ingrese el monto con el que va a pagar");
int monto = Convert.ToInt32(Console.ReadLine());
if (monto < Totalapagar)
{
    Console.WriteLine("------------------ERROR--------------------");
    Console.WriteLine("        monto ingresado no válido");
    System.Environment.Exit(0);

}
else if (monto == Totalapagar)
{
    Console.WriteLine("             Gracias por su pago");
    Console.WriteLine("                vuelva pronto");
    Console.WriteLine("------------------OKLAND MALL--------------------");
}

else if (monto > Totalapagar)
{
    int cambio = monto - Totalapagar;
    Console.WriteLine("Su cambio es: Q." + cambio);
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("FAVOR, RECOJA SU CAMBIO");
    Console.WriteLine("-------------------------------------------------");
    Console.ReadLine();

    Console.WriteLine("Cambio: " + cambio);

    int b100 = cambio / 100;
    cambio = cambio % 100;

    int b50 = cambio / 50;
    cambio = cambio % 50;

    int b20 = cambio / 20;
    cambio = cambio % 20;

    int b10 = cambio / 10;  
    cambio = cambio % 10;

    int b5 = cambio / 5;
    cambio = cambio % 5;

    int b1 = cambio / 1;

    
    Console.WriteLine("Billetes de Q100: " + b100);
    Console.WriteLine("Billetes de Q50: " + b50);
    Console.WriteLine("Billetes de Q20: " + b20);
    Console.WriteLine("Billetes de Q10: " + b10);
    Console.WriteLine("Billetes de Q5: " + b5);
    Console.WriteLine("Billetes de Q1: " + b1);

    Console.WriteLine("");
    Console.WriteLine("             Gracias por su pago");
    Console.WriteLine("                vuelva pronto");
    Console.WriteLine("------------------OKLAND MALL--------------------");
}

Console.WriteLine("");
Console.WriteLine("=================================================");


Console.WriteLine("LABORATORIO #4");
Console.WriteLine("Finalizando operaciones...");
Console.ReadLine();
Console.WriteLine("Gracias...");
Console.WriteLine("=================================================");
