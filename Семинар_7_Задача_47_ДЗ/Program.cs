// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.Write("Введите количество строк двумерного массива: ");
int rowCount = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов двумерного массива: ");
int columnCount = int.Parse(Console.ReadLine()!);

double[,] array = FillArray(rowCount, columnCount);
PrintArray(array);

double[,] FillArray(int rows, int columns)
{
    double[,] filledArray = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < filledArray.GetLength(0); i++)
    {
        for (int j = 0; j < filledArray.GetLength(1); j++)
        {
            filledArray[i,j] = Math.Round(rnd.NextDouble() * rnd.Next(-10, 10), 1);
        }
    }
    return filledArray;
}


void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (j < inputArray.GetLength(1) - 1) Console.Write($"{inputArray[i,j], 4}, ");
            else Console.Write($"{inputArray[i,j], 4}");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}
