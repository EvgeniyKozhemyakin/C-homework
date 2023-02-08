// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] GreatMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    int size = rows * columns * depth;
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
        int temp = arr[i];

        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arr[i] == arr[j])
                {
                    arr[i] = rnd.Next(min, max + 1);
                    j = 0;
                    temp = arr[i];
                }
                temp = arr[i];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {

                matrix[i, j, k] = arr[count];
                count++;

            }
        }
    }
    return matrix;
}
void PrintMatrix3D(int[,,] matrix3d)
{
    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3d.GetLength(2); k++)
            {
                Console.WriteLine($"{matrix3d[i, j, k]} ({i},{j},{k})");
            }

        }
    }
}

int[,,] arr3D = GreatMatrixRndInt(2, 2, 2, 0, 100);
PrintMatrix3D(arr3D);
