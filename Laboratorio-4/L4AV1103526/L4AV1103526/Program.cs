//1. Declaración de variables
Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("Ejercicio 1");
string nombre = "Link";
int nivel = 67;
float puntosDeVida = 100.5f;
bool es_un_jefe = false;
Console.WriteLine("Nombre: " + nombre + " Nivel: " + nivel + " Puntos de vida: " + puntosDeVida + " ¿Es un jefe? " + es_un_jefe);

Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("PRESIONE PARA AVANZAR A EJERCICIO 2...");
Console.ReadLine();
Console.WriteLine("------------------------------------------------------------------");


//2. Conversión implicita
Console.WriteLine("Ejercicio 2");
int numeroEntero = 1500;
long numeroLargo;
numeroLargo = numeroEntero;
Console.WriteLine("Numero largo: " + numeroLargo);
Console.ReadLine();
double numeroDecimal = numeroLargo;
Console.WriteLine("Numero decimal: " + numeroDecimal);

Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("PRESIONE PARA AVANZAR A EJERCICIO 3...");
Console.ReadLine();
Console.WriteLine("------------------------------------------------------------------");


//3. Casting explicito
Console.WriteLine("Ejercicio 3");
double precioexacto = 65.89;
int precioRedondeado;
precioRedondeado = (int)precioexacto;
Console.WriteLine("Precio exacto: " + precioexacto);
Console.WriteLine("Precio Redondeado: " + precioRedondeado);


Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("PRESIONE PARA AVANZAR A EJERCICIO 4...");
Console.ReadLine();
Console.WriteLine("------------------------------------------------------------------");


//4. De texto a número
Console.WriteLine("Ejercicio 4");
//int numero;
//numero = Console.ReadLine();
//Al intentar ejecutar desde este punto dice que no se puede convertir de string a int.
Console.WriteLine("Ingrese un número: ");
string entradausuario = Console.ReadLine();
int numero = int.Parse(entradausuario);
int resultado = numero + 5;
Console.WriteLine("Resultado: " + resultado);

Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("PRESIONE PARA AVANZAR A EJERCICIO 5...");
Console.ReadLine();
Console.WriteLine("------------------------------------------------------------------");


//5. El uso de clase "Convert"
Console.WriteLine("Ejercicio 5");
string Valortexto = "true";
bool valorbooleano = Convert.ToBoolean(Valortexto);
string ValorDecimal = "6.4285";
double valordouble = Convert.ToDouble(ValorDecimal);
Console.WriteLine("Valor booleano: " + valorbooleano);
Console.WriteLine("Valor double: " + valordouble);

Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("PRESIONE PARA AVANZAR A EJERCICIO 6...");
Console.ReadLine();
Console.WriteLine("------------------------------------------------------------------");


//6. Conversión a texto
Console.WriteLine("Ejercicio 6");
double pi = 3.14159265;
string cadena = pi.ToString("F2");
Console.WriteLine(cadena);

Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("PRESIONE PARA AVANZAR A EJERCICIO 7...");
Console.ReadLine();
Console.WriteLine("------------------------------------------------------------------");


//7. Calculadora IVA
Console.WriteLine("Ejercicio 7");
Console.WriteLine("Ingrese el precio del producto: ");
string precioProducto = Console.ReadLine();
double precio = Convert.ToDouble(precioProducto);
double iva = precio*0.21;

double total = precio + iva;

int totalRedondeado = (int)total;

Console.WriteLine("El total a pagar es: " + totalRedondeado);

Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("EJERCICIOS FINALIZADOS");
Console.WriteLine("PRESIONE PARA SALIR DEL PROGRAMA...");
Console.ReadLine();
Console.WriteLine("------------------------------------------------------------------");

