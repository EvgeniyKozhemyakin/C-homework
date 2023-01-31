// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.(каждая сторона треугольника меньше суммы двух других)

bool IsExistTriangle(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) return true;
    return false;
}

Console.WriteLine("Введите три числа:");

Console.Write("Первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());


bool isExistTriangle = IsExistTriangle(number1,number2,number3);

Console.WriteLine(isExistTriangle ? "да" : "нет");