using Resolucion_Ejercicio_Nro_13.EjercicioBilletera;

var Billetera1 = new Billetera(3,4,6,8,9,3,5);
Billetera1.BilletesDe10 = 3;
Billetera1.BilletesDe20 = 5;
Billetera1.BilletesDe50 = 5;
Billetera1.BilletesDe100 = 7;
Billetera1.BilletesDe200 = 9;
Billetera1.BilletesDe500 = 5;
Billetera1.BilletesDe1000 = 7;

Console.WriteLine($"Billetes de 10: {Billetera1.BilletesDe10}");
Console.WriteLine($"Billetes de 20: {Billetera1.BilletesDe20}");
Console.WriteLine($"Billetes de 50: {Billetera1.BilletesDe50}");
Console.WriteLine($"Billetes de 100: {Billetera1.BilletesDe100}");
Console.WriteLine($"Billetes de 200: {Billetera1.BilletesDe200}");
Console.WriteLine($"Billetes de 500: {Billetera1.BilletesDe500}");
Console.WriteLine($"Billetes de 1000: {Billetera1.BilletesDe1000}");

Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("Billetera 1: ");
Billetera1.Total();
Console.WriteLine("---------------------------------------------------------");
var Billetera2 = new Billetera(5,6,3,4,8,9,3);
Billetera2.BilletesDe10 = 7;
Billetera2.BilletesDe20 = 2;
Billetera2.BilletesDe50 = 4;
Billetera2.BilletesDe100 = 9;
Billetera2.BilletesDe200 = 7;
Billetera2.BilletesDe500 = 3;
Billetera2.BilletesDe1000 = 6;

Console.WriteLine($"Billetes de 10: {Billetera2.BilletesDe10}");
Console.WriteLine($"Billetes de 20: {Billetera2.BilletesDe20}");
Console.WriteLine($"Billetes de 50: {Billetera2.BilletesDe50}");
Console.WriteLine($"Billetes de 100: {Billetera2.BilletesDe100}");
Console.WriteLine($"Billetes de 200: {Billetera2.BilletesDe200}");
Console.WriteLine($"Billetes de 500: {Billetera2.BilletesDe500}");
Console.WriteLine($"Billetes de 1000: {Billetera2.BilletesDe1000}");
Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("Billetera 2: ");
Billetera2.Total();
Console.WriteLine("---------------------------------------------------------");
