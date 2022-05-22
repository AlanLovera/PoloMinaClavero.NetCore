Console.Clear();

//Determinamos la cantidad de filas
Console.WriteLine("Ingrese la cantidad de filas que desea: ");
int filas = int.Parse(Console.ReadLine());

//Determinamos la cantidad de columnas
Console.WriteLine("Ingrese la cantidad de columnas que desea: ");
int columnas = int.Parse(Console.ReadLine());

//Declaramos vector promedio
double[] promedios = new double[columnas];
//Creamos la matriz numeros
int[,] numeros = new int[filas, columnas];

//Recorremos matriz
for (int i = 0; i < filas; i++)
{
    //Recorremos las columnas
    Console.WriteLine($"Estamos en la fila {i + 1}");
    
    //Recorremos las filas
    for (int j = 0; j < columnas; j++)
    {
        Console.WriteLine($"Estamos en la columna {j + 1}");
        numeros[filas, columnas] = int.Parse(Console.ReadLine());
    }
}

//Recorremos la matriz para mostrar sus valores
for (int i = 0; i < columnas; i++)
{
    for (int j = 0; j < filas; j++)
    {
        Console.WriteLine($"Valor de la fila {i + 1} y columna {j + 1} = {numeros[i, j]}");
    }
}

//Calculamos promedio
for (int i = 0; i < columnas; i++)
{
    double valores = 0;
    for (int j = 0; j < filas; j++)
    {
        valores += numeros[j, i];
    }
    promedios[i] = valores / filas;
    
}
//Mostramos el resultado
for (int i = 0; i < promedios.Length; i++)
{
    Console.WriteLine($"El promedio de la columna {i + 1} es igual a = {promedios[i]}");
}