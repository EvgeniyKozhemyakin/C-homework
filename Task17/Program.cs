// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
int Quarter (int xc, int yc) {
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;     
    
}

Console.WriteLine("Введите координату X:");
int corX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y:");
int corY = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(corX, corY);
string result = quarter > 0 
    ? $"Указанные координаты соответствуют четверти -> {quarter}"
    : "Некорректные координаты";

Console.WriteLine(result);


