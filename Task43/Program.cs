// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FunctionIntersectionCoordinateX(double kn1, double kn2, double bn1, double bn2)
{
    return Math.Round((bn2 - bn1) / (kn1 - kn2), 1, MidpointRounding.ToZero);
}
double FunctionIntersectionCoordinateY(double kn1, double kn2, double bn1, double bn2)
{
    return Math.Round((kn2 * bn1 - kn1 * bn2) / (kn2 - kn1), 1, MidpointRounding.ToZero);
}

Console.Write("Введите значение k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2:");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2:");
double b2 = Convert.ToInt32(Console.ReadLine());

double coordinateX = FunctionIntersectionCoordinateX(k1, k2, b1, b2);
double coordinateY = FunctionIntersectionCoordinateY(k1, k2, b1, b2);
Console.WriteLine($"[{coordinateX} ; {coordinateY}]");


