Console.Clear();

Console.WriteLine("Ingresar los 2 valores de la matriz");

Console.WriteLine("Ingrese la cantidad de fila");
int fila = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de columnas");
int columna = int.Parse(Console.ReadLine());

int[,] numeros = new int[fila, columna];
double[] promedios = new double[columna];
double valores = 0;

for (int i = 0; i < fila; i++)
{
    for (int j = 0; j < columna; j++)
    {
        Console.WriteLine($"Ingresar los valores de la fila {i + 1} y columna {j + 1}");
        numeros[i, j] = int.Parse(Console.ReadLine()); 
    }
}
Console.WriteLine();
for (int i = 0; i < fila; i++)
{
    for (int j =0; j < columna; j++)
    {
        Console.WriteLine($"Valor de la fila {i + 1} y columna {j + 1} = {numeros[i, j]}");
    }
}
Console.WriteLine();
for (int i = 0; i < columna; i++)
{
    for (int j = 0; j < fila; j++)
    {
        valores += numeros[j, i];
    }
    promedios[i] = valores / fila;
    valores = 0;
}
for (int i=0; i<promedios.Length;i++)
{
    Console.WriteLine($"El promedio de la columna{i + 1} es igual a = {promedios[i]}");
}