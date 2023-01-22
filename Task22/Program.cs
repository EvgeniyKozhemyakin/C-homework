// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void Square(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i,5} --> {i * i,5}");
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1) 
{
    Console.WriteLine("Некорректный ввод");
    return;
}
Square(number);


