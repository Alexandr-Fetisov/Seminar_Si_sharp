// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


Console.Clear();

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

void FillArray(int[,] coll)
{
    Random rnd = new Random();
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = rnd.Next(1, 11);
        }
    }
}

void PrintArray(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            Console.Write($"{coll[i, j], 4}");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

void DeleteRowColumnMinElement(int[,] coll)
{
    int min_i = 0;
    int min_j = 0;
    int minElement = coll[0, 0];
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            if (coll[i, j] < minElement) 
            {
                minElement = coll[i, j];
                min_i = i;
                min_j = j;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент  = {minElement}, с индексом ({min_i},{min_j})");

    int[,] arrNew = new int[coll.GetLength(0) - 1, coll.GetLength(1) - 1];
    int second_i = 0;
    int second_j = 0;
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        if (i != min_i)
        {
            second_j = 0;
            for (int j = 0; j < coll.GetLength(1); j++)
            {
                if (j != min_j)
                {
                    arrNew[second_i, second_j] = coll[i,j];
                    second_j++;
                }
            }
            second_i++;
        }
    }
    PrintArray(arrNew); 
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
DeleteRowColumnMinElement(matrix);