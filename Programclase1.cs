// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;

Console.WriteLine("SECCION 1: PROGRAMACION ESTRUCTURADA");

//programacion estructurada 

//las variables se crean especifiqando el tipo de dato

//---ejemplo de variable
string nombre = "Juan";
Console.WriteLine("Hola " + nombre);

int edad = 25;
Console.WriteLine("Edad: " + edad);

//---datos primitivos

//int es para numeros enteros
//rango de -2147483648 a 2147483647
int numero = 10;
Console.WriteLine("Numero: " + numero);

//uint es para numeros enteros sin signo
uint numeroEnteroSinSigno = 4000000000; //rango de 0 a 4294967295
Console.WriteLine("Numero entero sin signo: " + numeroEnteroSinSigno);


//sbyte es para numeros enteros pequeños
sbyte numeroPequeno = -100; //rango de -128 a 127
Console.WriteLine("Numero pequeño: " + numeroPequeno);

//byte es para numeros enteros pequeños sin signo
byte numeroSinSigno = 200; //rango de 0 a 255   
Console.WriteLine("Numero sin signo: " + numeroSinSigno);

//short es para numeros enteros medianos
short numeroMediano = -30000; //rango de -32768 a 32767
Console.WriteLine("Numero mediano: " + numeroMediano);

ushort numeroMedianoSinSigno = 60000; //rango de 0 a 65535
Console.WriteLine("Numero mediano sin signo: " + numeroMedianoSinSigno);

//long es para numeros enteros grandes
long numeroGrandeEntero = 9223372036854775807; //rango de -9223372036854775808 a 9223372036854775807
Console.WriteLine("Numero grande entero: " + numeroGrandeEntero);

//ulong es para numeros enteros grandes sin signo
ulong numeroGrandeEnteroSinSigno = 18446744073709551615; //rango de 0 a 18446744073709551615
Console.WriteLine("Numero grande entero sin signo: " + numeroGrandeEnteroSinSigno);

//---datos de texto
//string es para cadenas de texto
//rango de 0 a 2^31-1 caracteres
string texto = "Hola Mundo";
Console.WriteLine("Texto: " + texto);

//---datos booleanos
bool esVerdadero = true; //verdadero o falso
Console.WriteLine("Es verdadero: " + esVerdadero);

char letra = 'A';
Console.WriteLine("Letra: " + letra);

//---datos flotantes y decimales
float decimalNumero = 10.5f;
Console.WriteLine("Numero decimal: " + decimalNumero);

double numeroGrande = 1000000.99;
Console.WriteLine("Numero grande: " + numeroGrande);

decimal numeroDecimal = 1000.50m;
Console.WriteLine("Numero decimal con alta precision: " + numeroDecimal);

//la diferencia entre float, double y decimal es la precision y el rango de valores que pueden almacenar. 
//float es menos preciso que double, y decimal es el mas preciso de los tres, ideal para valores monetarios.


//tipos de datos de fechas y horas
DateTime fechaActual = DateTime.Now;
Console.WriteLine("Fecha y hora actual: " + fechaActual);
//(esto se declara tipo objeto DateTime por que DateTime lo define el framework de .NET como un tipo de dato especial para manejar fechas y horas)

DateOnly fechaSolo = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine("Fecha actual sin hora: " + fechaSolo);
//esto lo que hace es solo mostrar la fecha sin la hora, es util cuando solo necesitas trabajar con fechas sin preocuparte por la hora.

TimeOnly horaActual = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine("Hora actual sin fecha: " + horaActual);
//esto lo que hace es solo mostrar la hora sin la fecha, es util cuando solo necesitas trabajar con horas sin preocuparte por la fecha.


// ----OPERACIONES CON VARIABLES
//suma
int a = 5;
int b = 10;
int suma = a + b; //suma de dos enteros 
Console.WriteLine("Suma: " + suma);

//conversion de tipos
//pasar un tipo de dato a otro
int numeroEntero = 20;
double numeroDecimalConvertido = Convert.ToDouble(numeroEntero); //convertir int a double
Console.WriteLine("Numero entero convertido a decimal: " + numeroDecimalConvertido);

//de string a int
string numeroComoTexto = "30";
int numeroConvertido = Convert.ToInt32(numeroComoTexto); //convertir string a int
Console.WriteLine("Numero convertido de texto a entero: " + numeroConvertido);

//para pedir datos al usuario
Console.WriteLine("Ingrese su nombre:");
string nombreUsuario = Console.ReadLine(); //lee una linea de texto ingresada por el usuario
Console.WriteLine("Hola " + nombreUsuario + ", bienvenid@!");

//para pedir un numero al usuario (mas larga)
// Console.WriteLine("Ingrese su edad:");
// string edadComoTexto = Console.ReadLine(); //lee una linea de texto ingresada por el usuario
// int edadUsuario = Convert.ToInt32(edadComoTexto); //convierte el texto a entero
// Console.WriteLine("Tu edad es: " + edadUsuario);

//otra forma de pedir un numero al usuario (con convert)
// Console.Write("Ingrese su edad: ");
// int edadUsuario1 = Convert.ToInt32(Console.ReadLine()); //lee una linea de texto y la convierte a entero
// Console.WriteLine("Tu edad es: " + edadUsuario1);

//otra forma de pedir un numero al usuario (con parse)
// Console.Write("Ingrese su edad: ");
// int edadUsuario2 = int.Parse(Console.ReadLine()); //lee una linea de texto y la convierte a entero
// Console.WriteLine("Tu edad es: " + edadUsuario2);   


//consultar al usuario nombre, edad, estatura y peso
// calcular el IMC (Indice de Masa Corporal) y mostrar un mensaje segun el resultado
// IMC = peso / (estatura * estatura)


//solicitar nombre y cantidad de pesos, Conversion de pesos a otras monedas
//calcular y mostrar el equivalete de esa cantidad de pesos en dolares, euros y libras esterlinas
//mostrar el resultado con formato de moneda 

//en ambos ejercicios hacer comentarios describiendo las funcionalidades 

// Solicitar la edad al usuario y mostrarla
Console.WriteLine("Ingresa tu edad:");
int edadejer = int.Parse(Console.ReadLine());
Console.WriteLine("Tu edad es: " + edadejer);

// Solicitar la estatura al usuario en centímetros y mostrarla
Console.WriteLine("Ingresa tu estatura en cm:");
int estatura = int.Parse(Console.ReadLine());
Console.WriteLine("Tu estatura es: " + estatura + " cm");

// Solicitar el peso al usuario en kilogramos y mostrarlo
Console.WriteLine("Ingresa tu peso en kg:");
int peso = int.Parse(Console.ReadLine());
Console.WriteLine("Tu peso es: " + peso + " kg");

// Calcular el IMC (Índice de Masa Corporal)
// La estatura debe estar en metros para el cálculo
double estaturaMetros = estatura / 100.0; // Convertir cm a metros
double imc = peso / (estaturaMetros * estaturaMetros);
Console.WriteLine("Tu IMC es: " + imc.ToString("F2")); // Mostrar el IMC con dos decimales

// Mostrar mensaje según el resultado del IMC
if (imc < 18.5)
{
    // Bajo peso
    Console.WriteLine(nombreUsuario + " tienes bajo peso");
}
else if (imc >= 18.5 && imc < 25)
{
    // Peso normal
    Console.WriteLine(nombreUsuario + " tu peso es normal");
}
else if (imc >= 25 && imc < 30)
{
    // Sobrepeso
    Console.WriteLine(nombreUsuario + " tienes sobrepeso");
}
else
{
    // Obesidad
    Console.WriteLine(nombreUsuario + " tienes obesidad");
}
// Solicitar nombre y cantidad de pesos, conversión de pesos a otras monedas
// Calcular y mostrar el equivalente en dólares, euros y libras esterlinas
// Mostrar el resultado con formato de moneda y validar entradas

double cantidadPesosColombianos = 0;
bool entradaValida = false;

while (!entradaValida)
{
    Console.WriteLine("Ingrese la cantidad de pesos colombianos:");
    string entrada = Console.ReadLine();
    if (double.TryParse(entrada, out cantidadPesosColombianos) && cantidadPesosColombianos >= 0)
    {
        entradaValida = true;
    }
    else
    {
        Console.WriteLine("Por favor, ingrese un número válido y positivo.");
    }
}

// Tasas de cambio (ejemplo, pueden variar)
double tasaPesoMexicano = 0.0043; // 1 COP = 0.0043 MXN (ejemplo)
double tasaDolar = 0.00025;       // 1 COP = 0.00025 USD (ejemplo)
double tasaEuro = 0.00023;        // 1 COP = 0.00023 EUR (ejemplo)

double pesosMexicanos = cantidadPesosColombianos * tasaPesoMexicano;
double dolares = cantidadPesosColombianos * tasaDolar;
double euros = cantidadPesosColombianos * tasaEuro;

Console.WriteLine("Equivalente en pesos mexicanos: " + pesosMexicanos.ToString("C2"));
Console.WriteLine("Equivalente en dólares: " + dolares.ToString("C2"));
Console.WriteLine("Equivalente en euros: " + euros.ToString("C2"));
