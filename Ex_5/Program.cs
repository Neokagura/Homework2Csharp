// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Add X");
int X= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add Y");
int Y= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add Z");
int Z= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add X2");
int X2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add Y2");
int Y2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add Z2");
int Z2= Convert.ToInt32(Console.ReadLine());

double result= Math.Sqrt((Math.Pow((X2-X), 2))+(Math.Pow((Y2-Y), 2))+(Math.Pow((Z2-Z), 2)));
Console.WriteLine(result);