// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//? ciclos 

// casi siempre va a comparar un dato con otro.
// entre parentesis solo van los parametros y estos parametros en los ciclos especifican desde donde empieza un ciclo y donde termina 

// i+= 4 : de cuanto en tanto el codigo va a realizar la operacion (cada 4 conteos)
// i++ : de uno en uno 


//! ciclo for

// for (int i = 1; i == 10; i++){
//     Console.WriteLine("Edad: ");
//     int edad = int.Parse(Console.ReadLine());
//     Console.WriteLine("Edad es "+ edad);
// }



//! ciclo while 
// cuando no se una cantidad fija de veces que se debe repetir un ciclo utilizamos el while 

// Console.WriteLine("Edad: ");
// int edad = int.Parse(Console.ReadLine());
// int edadparametro = 90;
// while (edad != edadparametro){
//     Console.WriteLine("Puede Igresar");

//     Console.WriteLine("Edad: ");
//     edad = int.Parse(Console.ReadLine());
// }




//! ciclo do while
// en el while verifica que se ingrese el dato para que el ciclo si se puede ejecutar 
// el ciclo do while por lo menos se ejecuta una vez y ya estando dentro del ciclo valida 

// sbyte edadusuario = 0;
// sbyte parametrocentinela = 99; 

// do{
//     Console.WriteLine("edad: "); 
//     edad = sbyte.Parse(Console.ReadLine());
// }while(edad != parametrocentinela);


// - imc
// - conversion de pesos 
// - sistema adminitrativo  
// - contador de agua 


//? ARRAYS: almacenar mas de un dato en una variable

// ejemplo: 
// --string[] nombres = new string[5]; // 5 es la cantidad de datos que se pueden almacenar en el array
// para agregar a ese array utilizamos extension .Add 


// --string[] nombres2 = new string[] {"Juan", "Pedro", "Maria", "Jose", "Ana"}; // se pueden inicializar los datos al momento de crear el array



// foreach (var item in collection){

// }

// foreach (var nombre in nombres2){
// Console.WriteLine(nombre); 
// }


// ? LISTAS 

// List<string> nombres = new List<string>();
// nombres.Add("Juan");
// nombres.Add("Pedro");
// nombres.Add("Maria");

// Console.WriteLine(nombres);


// List<string> anios = new List<string>();
// anios.Add(2092);
// anios.Add(1987);
// anios.Add(2009);

// Console.WriteLine(anios);


//? DICCIONARIO : tiene dos elementos clave, 1. la clave, 2. el valor. en donde se tiene que especificar el tipo de cada uno (que la clave sea tipo entero y los valores string)

// Dictionary<int, string> lista_productos = new Dictionary<int, string>(){
// {1, "Arroz"},
// {2, "Frijol"},
// {3, "Aceite"},
// {4, "Sal"},
// {5, "Azucar"}
// };

// foreach (var producto in lista_productos){
//     Console.WriteLine("Clave: " + producto.Key + " Valor: " + producto.Value);
// }


// inventario con control de stock 

// inicio de sesión 

// mensaje de bienvenida 
Console.WriteLine("Bienvenido al sistema de stock administrador, inicie sesión para continuar");
string nombreadmin = "Sharon";
string contraseña = "3588640";

Console.WriteLine("USUARIO: "); 
string usuarioingresado = Console.ReadLine(); 
Console.WriteLine("CONTRASEÑA: "); 
string contraseñaingresada = Console.ReadLine();

if (nombreadmin == usuarioingresado && contraseña == contraseñaingresada) {
    Console.WriteLine("CAMPOS CORRECTAMENTE INGRESADOS");

    Console.WriteLine("Bienvenido al sistema de stock " + usuarioingresado);
    Console.WriteLine("Seleccione una de las siguientes acciones para llevar a cabo");

    // diccionario para almacenar los productos
    Dictionary<int, string> lista_productos = new Dictionary<int, string>();
    bool continuar = true;

    while (continuar)
    {

        // Menú 
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Eliminar producto");
        Console.WriteLine("3. buscar producto");
        Console.WriteLine("4. mostrar todos los productos");
        Console.WriteLine("5. salir del sistema");
        string opcion = Console.ReadLine();


        switch (opcion)
        {
            case "1":
                Console.WriteLine("Ingrese el nombre del nuevo producto");
                string nombrenuevoproducto = Console.ReadLine();
                Console.WriteLine("Ingrese la llave del nuevo producto");
                int llavenuevoproducto;

                if (int.TryParse(Console.ReadLine(), out llavenuevoproducto))
                {
                    if (!lista_productos.ContainsKey(llavenuevoproducto))
                    {
                        lista_productos.Add(llavenuevoproducto, nombrenuevoproducto);
                        Console.WriteLine("Producto agregado con exito");
                    }
                    else
                    {
                        Console.WriteLine("ya existe un producto con esa llave");
                    }
                }
                else
                {
                    Console.WriteLine("La llave debe ser un número entero. Intente de nuevo.");
                    continue; // Vuelve al inicio del ciclo para pedir la opción nuevamente
                }
                break;


            case "2":
                Console.WriteLine("Ingrese la llave del producto a eliminar");
                int llaveproductoeliminar;
                if (int.TryParse(Console.ReadLine(), out llaveproductoeliminar)) {
                    if (lista_productos.Remove(llaveproductoeliminar))
                    {
                        Console.WriteLine("Producto elimnado con exito");
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado");
                    }
                } else {
                    Console.WriteLine("la llave debe ser un número");
                }
                break;
             case "3": //buscar un producto 
                Console.WriteLine("Ingrese la llave del producto a buscar");
                int IDproductoBuscar;
                if (int.TryParse(Console.ReadLine(), out IDproductoBuscar))
                {
                    if (lista_productos.TryGetValue(IDproductoBuscar, out string nombredelproducto))
                    {
                        Console.WriteLine($"Producto encontrado: {nombredelproducto}");
                    }
                    else
                    {
                        Console.WriteLine($"no se encontro el producto {IDproductoBuscar}");
                    }
                }
                else
                {
                    Console.WriteLine("La llave debe ser un número. ");
                }
                break;

            case "4": //mostrar todos los productos
                if (lista_productos.Count > 0) {
                    foreach (var producto in lista_productos) {
                        Console.WriteLine($"llave: {producto.Key} producto: {producto.Value}");
                    }
                } else {
                    Console.WriteLine("No hay productos en el inventario");
                }
                break;

            case "5":
                Console.WriteLine("te gustaria realizar una encuesta de sactisfacción(si/no)");
                string respuesta = Console.ReadLine();
                if (respuesta == "no")
                {
                    Console.WriteLine("saliendo del sistema... Vuelva pronto");
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("BIENVENIDO A LA ENCUESTA DE SACTISFACCIÓN DEL SISTEMA ADMINISTRATIVO, A CONTINUACIÓN PUNTUE DEL 1 AL 5 CADA UNO DE LOS CAMPOS CORRESPONDIENTES Y AL FINAL SE LE DIRA QUE TAN SACTISFECHO ESTA");

                    Console.WriteLine("Que le parecio la captura de errores en el sistema");
                    int preguntauno = int.Parse(Console.ReadLine());

                    Console.WriteLine("Que le parecieron las opciones del sistema");
                    int preguntados = int.Parse(Console.ReadLine());

                    Console.WriteLine("Que tan facil le parecio aprender a usar el sistema");
                    int preguntatres = int.Parse(Console.ReadLine());

                    Console.WriteLine("que tan sactisfecho esta con el sistema de inventario en general");
                    int preguntacuatro = int.Parse(Console.ReadLine());

                    Console.WriteLine("La navegación entre menús y opciones es sencilla");
                    int preguntacinco = int.Parse(Console.ReadLine());


                    int sumadeencuesta = preguntauno + preguntados + preguntatres + preguntacuatro + preguntacinco;

                    if (sumadeencuesta <= 5)
                    {
                        Console.WriteLine("Muy insatisfecho");
                    }
                    else if (sumadeencuesta <= 10 && sumadeencuesta >= 6)
                    {
                        Console.WriteLine("Insatisfecho");
                    }
                    else if (sumadeencuesta >= 11 && sumadeencuesta <= 15)
                    {
                        Console.WriteLine("Neutral");
                    }
                    else if (sumadeencuesta >= 16 && sumadeencuesta <= 20)
                    {
                        Console.WriteLine("sactisfecho");
                    }
                    else if (sumadeencuesta >= 21 && sumadeencuesta <= 25)
                    {
                        Console.WriteLine("Muy sactisfecho");
                    }
                    else
                    {
                        Console.WriteLine("Datos incorrectos, vuelva a intentar");

                    }
                    Console.WriteLine("Gracias por completar la encuesta, saliendo del sistema... Vuelva pronto");
                    continuar = false; 
                }
                
                break;

            default:
                Console.WriteLine("Opción No Valida");
                break;
        }
    }





}else{
     Console.WriteLine("DATOS INCORRECTOS, VUELVA A INTENTAR");
}
// 
// Caso de Uso 1: Administrar inventario
// Nombre: Administrar inventario
// ID: CU-001
// Actor principal: Administrador del sistema
// Descripción: Permite agregar, eliminar, buscar y mostrar productos dentro del inventario.
// Precondiciones:

// El usuario debe iniciar sesión correctamente con credenciales válidas.

// Flujo principal:

// El administrador inicia sesión.

// El sistema muestra un menú con las opciones disponibles:

// Agregar producto

// Eliminar producto

// Buscar producto

// Mostrar todos los productos

// Salir

// El administrador selecciona una opción y sigue las instrucciones en pantalla.

// El sistema valida la información ingresada (por ejemplo, que la llave sea un número y que no se repita).

// El sistema actualiza la lista de productos y muestra mensajes de confirmación o error.

// Flujos alternativos:

// A1: Si el producto ya existe con la misma llave, el sistema muestra un mensaje de error.

// A2: Si se intenta eliminar o buscar un producto que no existe, el sistema muestra un mensaje de advertencia.

// A3: Si el usuario selecciona "Salir", se le ofrece realizar la encuesta de satisfacción antes de cerrar.

// Postcondiciones:

// El inventario queda actualizado con los cambios realizados.

// Requisitos especiales:

// Uso exclusivo para usuarios con credenciales válidas.

// Prioridad: Alta

// Caso de Uso 2: Realizar encuesta de satisfacción
// Nombre: Realizar encuesta de satisfacción del sistema
// ID: CU-002
// Actor principal: Administrador (usuario que cierra sesión)
// Descripción: Permite que el usuario evalúe la experiencia de uso del sistema mediante una serie de preguntas puntuadas del 1 al 5.
// Precondiciones:

// El usuario debe haber usado el sistema de inventario y seleccionar "sí" cuando se le pregunte si desea realizar la encuesta.

// Flujo principal:

// El sistema pregunta si el usuario desea realizar la encuesta de satisfacción.

// El usuario responde "sí".

// El sistema presenta 5 preguntas relacionadas con la experiencia de uso del sistema.

// El usuario responde cada pregunta con un valor del 1 al 5.

// El sistema suma las puntuaciones y clasifica el nivel de satisfacción:

// Muy insatisfecho

// Insatisfecho

// Neutral

// Satisfecho

// Muy satisfecho

// El sistema muestra el resultado y agradece al usuario.

// Flujos alternativos:

// A1: Si el usuario responde "no" a la encuesta, el sistema finaliza la ejecución directamente.

// A2: Si las respuestas no están en el rango 1-5, el sistema muestra un mensaje de datos incorrectos.

// Postcondiciones:

// El sistema registra (o en este caso, muestra) el nivel de satisfacción final del usuario.

// Requisitos especiales:

// Todas las respuestas deben estar en el rango de 1 a 5.

// Prioridad: Media

