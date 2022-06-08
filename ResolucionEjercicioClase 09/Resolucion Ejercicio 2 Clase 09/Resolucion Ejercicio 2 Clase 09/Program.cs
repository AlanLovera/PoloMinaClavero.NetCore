// Se le asigna filas y columnas al carton de Bingo
int[,] cartonBingo = new int[3, 9];

//Se crea la variable random para utilizar en el carton con nros aleatorios
Random random = new Random();

var respuesta = "s";

while (respuesta != "n")
{

    //bucle para generar carton de bingo
    for (int f = 0; f < 3; f++)
    {
        for (int c = 0; c < 9; c++)
        {
            int valMin = (c * 10) + 1;
            int valMax = (c + 1) * 10; 
            if(c==0)
            {
                valMin += 1;
            }
            else if (c==8)
            {
                valMax += 1;
            }
            cartonBingo[f, c] = random.Next(valMin, valMax);
        }
    }

    //imprime en pantalla el carton generado
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            Console.Write($"     {cartonBingo[i, j]}    ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Desea generar otro carton? S/N");
    respuesta = Console.ReadLine();

}

//Nota: No pude resolver dejar los espacios en blanco 