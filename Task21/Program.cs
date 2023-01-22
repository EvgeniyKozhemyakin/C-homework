// Задача 21: 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistanceBetween (int x1c, int y1c, int x2c, int y2c, int z1c, int z2c )
{   
    return Math.Sqrt((x2c - x1c) * (x2c - x1c) + (y2c - y1c) * (y2c - y1c) + (z2c - z1c) * (z2c - z1c) );  
}

Console.WriteLine("Введите координаты точки A (x1;y1;z1): ");
Console.Write("x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B (x2;y2;z2): ");
Console.Write("x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double distanceBetween = DistanceBetween(x1, y1, x2, y2, z1, z2);
double result = Math.Round(distanceBetween,2, MidpointRounding.ToZero);
Console.WriteLine(result);