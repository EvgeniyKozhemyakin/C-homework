// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.Write("Введите значение M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N:");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberM < 0) Console.WriteLine("Введите положительное число !");
else
{
    int result = Ackermann(numberM, numberN);
    Console.WriteLine($"Ackermann({numberM}, {numberN}) = {result}");
}




