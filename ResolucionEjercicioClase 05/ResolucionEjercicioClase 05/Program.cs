//Variable para inicializar el ciclo while
var respuesta = "S";

//Punto 5: Si la respuesta es "S" repetir desde el punt 1
while (respuesta.ToUpper() == "S")
{
    //Punto 1: Borrar la pantalla
    Console.Clear();

    //Punto 2: Pedir el nombre de una persona
    Console.WriteLine("Ingrese su nombre: ");
    var nombre = Console.ReadLine();

    //Punto 3: Saludarlo con un texto que diga "¡Hola [NombreIngrsado]!"
    Console.WriteLine($"¡Hola {nombre}!");

    //Punto 4: Preguntar si quiere continuar
    Console.WriteLine("Desea continuar con el ciclo? (S/N)");
    respuesta = Console.ReadLine();
}

//Punto 6: Si la respuesta es "N" finalizar un programa que diga: "Programa finalizado correctamente
if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    /*Punto 7: Si la respuesta no es ni "S" ni "N" que también finalice el programa, pero mostrando un mensaje
    que diga "Opcioón no válida" */
    Console.WriteLine("Opción no válida");
}
