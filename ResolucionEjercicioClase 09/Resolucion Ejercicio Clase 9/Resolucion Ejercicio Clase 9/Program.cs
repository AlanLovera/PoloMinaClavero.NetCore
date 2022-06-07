Console.WriteLine("Ingrese la longitud de un vector");
var dato = Console.ReadLine();
int vector = int.Parse(dato);
int[] miVector = new int[vector];
Random random = new Random();
for (int i=0; i < miVector.Length; i++)
{
    miVector[i] = random.Next(100);
    Console.WriteLine(miVector[i]);
}
Console.WriteLine(miVector.Length);


for (int indiceIzquierdo = 0; indiceIzquierdo < miVector.Length / 2; indiceIzquierdo ++)
{
    int indiceDerecho = miVector.Length - indiceIzquierdo - 1;
    int vectorTemporal = miVector[indiceDerecho];
    miVector[indiceIzquierdo] = vectorTemporal;
}

Console.WriteLine("Vector Invertido");
foreach (var elemento in miVector)
{
    Console.WriteLine(elemento);
}