//Punto 1: Generar numero secreto con la siguiente instrucción
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

var contador = 0;

/*Punto 2: Pedir al usuario que ingrese un numero y que intente
adivinar el numero que eligió la computadora*/
Console.WriteLine("Bienvenido al juego: ¡Adivina y gana!");
Console.WriteLine("Intenta adivinar el número generado por la computadora");
int numIngresado;
do //Creación del bucle necesario con el contador de intentos
{
    contador++;
    //Retorno al paso Nro 2 del codigo
    Console.WriteLine("Tienes que ingresar un numero del 1 al 20");
    numIngresado = int.Parse(Console.ReadLine());

    if (numIngresado > numeroSecreto)
    {
        //Punto 3: Devolver respuesta si el numero ingresado es mayor
        Console.WriteLine("El numero ingresado es mayor al numero secreto, intente nuevamente");
    }
    else if (numIngresado < numeroSecreto)
    {
        //Punto 4: Devolver respuesta si el numero ingresado es menor
        Console.WriteLine("El numero ingresado es menor que el numero secreto, intente nuevamente");
    }
}
while (numIngresado != numeroSecreto);

//Punto 5: Mensaje para mostrar y finalizar el programa si los numeros coinciden
if (numIngresado == numeroSecreto)
{
    Console.WriteLine("¡¡Felicitaciones, has adivinado el número!!");
    Console.WriteLine($"El numero secreto era {numeroSecreto}");
    Console.WriteLine($"Lo has logrado en {contador} veces");
}