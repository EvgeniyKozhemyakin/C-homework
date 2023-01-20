// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string Possiblecoor (int num) {
    if (num == 1) return "x > 0 , y > 0";
    if (num == 2) return "x > 0 , y < 0";
    if (num == 3) return "x < 0 , y < 0";
    return "x < 0 , y > 0";       
}

Console.WriteLine("Введите номер четверти координат :");
int quarter = Convert.ToInt32(Console.ReadLine());

string possibleCoor = Possiblecoor(quarter);
string result = quarter > 4 || quarter < 1 
            ? "Некорректный ввод" 
            : possibleCoor;
Console.WriteLine(result);