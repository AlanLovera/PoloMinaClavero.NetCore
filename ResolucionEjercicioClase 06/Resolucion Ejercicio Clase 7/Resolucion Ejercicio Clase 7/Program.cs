Console.Clear();

//Iniciamos el programa
Console.WriteLine("Bienvenido, vamos a realizar algunos cálculos...");
Console.WriteLine();

//Variables a utilizar
int suma = 0;
double promedio;

//Punto 1: Pedimos 1os numeros al usuario
int[] numeros = new int[10];
Console.WriteLine("Primero ingrese 10 numeros: ");
Console.WriteLine();
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Vamos por el numero {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine()); 
}
Console.WriteLine();

//Punto 6: Mostramos los numeros ingresados
Console.WriteLine("Los numeros ingresados son: ");
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i]);
    Console.Write("-");
}
Console.WriteLine();
//Punto 2: Suma total de los numeros
for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}
Console.WriteLine($"La suma total de los numeros ingresados es: {suma}");
Console.WriteLine();
Console.WriteLine();

//Puntos 3 y 4: Obtener el mayor y el menor numero ingresado
int mayor = numeros[0];
int menor = numeros[0];
for (var i = 0; i < numeros.Length; i++)
{
    if (mayor < numeros[i])
    {
        mayor = numeros[i];
    }
    else if (menor > numeros[i])
    {
        menor = numeros[i];
    }
}
Console.WriteLine($"El numero mayor es {mayor}, el numero menor es {menor}");

//Punto 5: Obtener el promedio de todos los numeros:
promedio = suma / numeros.Length;
Console.WriteLine($"Y su promedio es: {promedio}");