// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// variables en c#
// int edadtipo = 30;
// float pi = 3.14f;
// char letra = 'B';
// string nombre = "Ana";
// bool esMayor = true;


// Console.WriteLine("ingrese su edad");
// sbyte edadusuario = sbyte.Parse(Console.ReadLine());
// sbyte parametroedad1 = 18;


// mayor o igual 
// if (edadusuario >= parametroedad1)
// {
//     Console.WriteLine("usted es mayor de edad");
// }
// else
// {
//     Console.WriteLine("usted es menor de edad");
// }

// menor o igual

// Console.WriteLine("ingrese su sueldo");
// decimal sueldousuario = convert.ToDecimal(Console.ReadLine());
// decimal parametrodesueldo = 3000m;


// ---- if anidado ----

// cualidades persona:
// edad 
// Console.WriteLine("ingrese su edad: ");
// sbyte edadpersona = sbyte.Parse(Console.ReadLine());


// // estado civil persona:
// Console.WriteLine("estado civil: ");
// string estadocivilpersona = Console.ReadLine();

// // responsabilidad
// Console.WriteLine("eres responsable: ");
// bool responsable = bool.Parse(Console.ReadLine());


// // hijos
// Console.WriteLine("hijos (responde: sin hijos, con hijos): ");
// string hijosestado = Console.ReadLine();



// // parametros 
// sbyte parametroedadpersona = 18;
// string parametroestadocivil = "soltero";
// bool parametroresponsable = true;
// string parametrohijos = "sin hijos";

// if (edadpersona >= parametroedadpersona) {
//     Console.WriteLine("usted es mayor de edad");

//     // segundo if 
//     if (estadocivilpersona == parametroestadocivil)
//     {
//         Console.WriteLine("usted es soltero, lo cual es ideal para el puesto");
//         // tercer if
//         if (responsable == parametroresponsable)
//         {

//             Console.WriteLine("usted es mayor de edad, soltero y responsable");
//             // cuarto if 
//             if (hijosestado != parametrohijos)
//             {
//                 Console.WriteLine("usted es el candidato ideal para el puesto");
//             }
//             else
//             {
//                 Console.WriteLine("usted tiene hijos, lo cual no es ideal");
//             }
//         }
//         else
//         {
//             Console.WriteLine("usted es no es responsable, lo cual no es ideal para el puesto   ");
//         }


//     }
//     else
//     {
//         Console.WriteLine("usted no es soltero, lo cual no es ideal para el puesto");
//     }

// } else {
//     Console.WriteLine("usted es menor de edad, lo cual no es ideal para el puesto");
// }



// uso de operadors logicos con if compuesto 


// if (edadpersona >= parametroedadpersona && estadocivilpersona == parametroestadocivil && responsable == parametroresponsable && hijosestado != parametrohijos)
// {
//     Console.Writeline("usted es el candidato ideal para el puesto");

// }
// else
// {
//     Console.WriteLine("usted no es ideal para el puesto");
// }

// operador logigo OR (||), si al menos una condicion es verdadera, se cumple la condicion del if
// if (edadpersona >= parametroedadpersona || estadocivilpersona == parametroestadocivil || responsable == parametroresponsable || hijosestado != parametrohijos)
// {
//     Console.Writeline("usted es el candidato ideal para el puesto");

// }
// else
// {
//     Console.WriteLine("usted no es ideal para el puesto");
// }


//  ---- EJMPLO ---- tipos de producto: tv, cel, tablet

// Console.WriteLine("ingrese el tipo de producto");
// string tipoproducto = Console.ReadLine();
// // parametros
// string parametrotv = "tv";
// string parametrotablet = "tablet";
// string parametrocel = "cel";

// // Variable de precio
// int precioproducto = 0;

// if (tipoproducto == parametrotv)
// {
//     precioproducto = 5000;
//     Console.WriteLine("el precio del producto es: " + precioproducto);
// }
// else
// {
//     if (tipoproducto == parametrotablet)
//     {
//         precioproducto = 2000000;
//         Console.WriteLine("el precio del producto es: " + precioproducto);
//     }
//     else
//     {
//         if (tipoproducto == parametrocel)
//         {
//             precioproducto = 600000;
//             Console.WriteLine("el precio del producto es: " + precioproducto);
//         }
//         else
//         {
//             Console.WriteLine("el producto no existe");
//         }
//     }
// }

// // con ||

// if (tipoproducto >= parametrotv || tipoproducto == parametrotablet || tipoproducto == parametrocel )
// {
//     precioproducto = 5000;
//     Console.Writeline("el precio del producto es: " + precioproducto);

// }
// else
// {
//     Console.WriteLine("usted no es ideal para el puesto");
// }

// switch (tipoproducto)
// {
//     case "tv":
//         precioproducto = 5000;
//         Console.WriteLine("el precio del producto es: " + precioproducto);
//         break;
//     case "tablet":
//         precioproducto = 2000000;
//         Console.WriteLine("el precio del producto es: " + precioproducto);
//         break;
//     case "cel":
//         precioproducto = 600000;
//         Console.WriteLine("el precio del producto es: " + precioproducto);
//         break;
//     default:
//         Console.WriteLine("el producto no existe");
//         break;
// }


// hacer un menu de opcines que 
// - muestre la fecha actual 
// - mostrar el nombre del creador
// - mostrar un mensaje motivador 
// - salir del programa


// Console.WriteLine("seleccione una opcion: ");
// Console.WriteLine("1. Mostrar fecha actual");
// Console.WriteLine("2. mostra nombre del creador");
// Console.WriteLine("3. mostrar mensaje motivador ");
// Console.WriteLine("4. salir del programa");
// string opcion = Console.ReadLine();

// switch (opcion)
// {
//     case "1":
//     Console.WriteLine("Fecha actual: " + DateTime.Now.ToString("dd/MM/yyyy"));
//         break;
//         case "2":
//     Console.WriteLine("by Sebastian Wilson");
//         break;
//         case "3":
//     Console.WriteLine("Eres maravilloso y capaz de lograr todo lo que te propongas");
//         break;
//         case "4":
//     Console.WriteLine("saliendo del programa...");
//         break;
//     default:
//     Console.WriteLine("la opcion no es valida"); 
//         break;  
// }


// aplicacion tipo consola que determine los niveles de valgo, 
// que tenga rangos, 5- 10 nivel a 11- 15 nivel b (masomenos 4 rangos )

// Console.WriteLine("ingrese su nombre ");
// string nombrepaciente = Console.ReadLine();

// Console.WriteLine("ingrese su edad ");
// int edadpaciente = int.Parse(Console.ReadLine());

//  Console.WriteLine("ingrese su nivel de valgo (1-20) ");
//     int valgo = int.Parse(Console.ReadLine());


// if (edadpaciente <= 10 )
// {
//     if (valgo <= 13)
//     {
//         Console.WriteLine($"hola {nombrepaciente} tienes un nivel de valgo normal que se restaurar con el tiempo al estandar normal");
//     }
//     else
//     {
//         Console.WriteLine("si su valgo es mayor a 13 considere consultar un medico para que se puedan aplicar medidas de correción ");
//     }


// }
// else if (edadpaciente >= 11 && edadpaciente <= 120)
// {
//     if (valgo <= 8)
//     {
//         Console.WriteLine($"hola {nombrepaciente} tienes un nivel de valgo normal y no hay de que preocuparse");
//     }
//     else
//     {
//         Console.WriteLine($"hola {nombrepaciente} tienes un nivel de valgo anormal superior a 7, considere consultar un medico para que se puedan aplicar medidas de correción ");
//     }
// }

// realizar un programa de cajero que muestre 3 opciones (consultar saldo, retirar dinero, salir)
// saldo inicial: 500.000
// si elige retirar, debe solicitar la cantidad a retirar, y verificar que si haya saldo suficiente
// descontar el saldo y mostrar el nuevo saldo
// mostra mensaje de despedida al salir del programa

Console.WriteLine("Bienvenido al cajero automático");
Console.Write("ingrese su nombre: ");
string usuario = Console.ReadLine();



bool continuar = true;

while (continuar)
{
    Console.WriteLine($"Hola {usuario}, seleccione una de las siguientes opciones:");
    Console.WriteLine("1. retirar dinero");
    Console.WriteLine("2. consultar saldo ");
    Console.WriteLine("3. Ingresar dinero");
    Console.WriteLine("4. Salir");
    Console.Write("Ingrese el número de la opción elegida: ");
    string opcion = Console.ReadLine();
    decimal saldo;
    decimal nuevosaldo;

    // ---
    switch (opcion)
    {
        case "1":
            saldo = 500000; // saldo inicial
            Console.WriteLine("Ingrese la cantidad a retirar: ");
            int saldoRetiro = int.Parse(Console.ReadLine());
            if (saldo <= saldoRetiro)
            {
                Console.WriteLine("Saldo insuficiente para realizar el retiro.");
            }
            else
            {
                nuevosaldo = saldo - saldoRetiro;
                Console.WriteLine($"Retiro exitoso. Su nuevo saldo es: {nuevosaldo}");
            }
            break;
        case "2":
            saldo = 500000; // saldo inicial
            Console.WriteLine($"Su saldo actual es: {saldo}");
            break;
        case "3":
            saldo = 500000; // saldo inicial
            Console.WriteLine("Ingrese la cantidad a ingresar: ");
            decimal cantidadIngreso = decimal.Parse(Console.ReadLine());
            nuevosaldo = saldo + cantidadIngreso;
            Console.WriteLine($"Ingreso exitoso. Su nuevo saldo es: {nuevosaldo}");
            break;

        case "4":
            Console.WriteLine("Gracias por usar el cajero automático. ¡Hasta luego!");
            continuar = false; // salir del bucle
            break; 

        default:
            Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
            break;
    }
    
}

