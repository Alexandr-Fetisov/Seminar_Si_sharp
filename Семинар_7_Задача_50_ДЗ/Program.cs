// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет
Console.Clear();

Console.Write("Введите количество строк двумерного массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату строки: ");
int findM = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату столбца: ");
int findN = int.Parse(Console.ReadLine()!);


int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write("[");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(20);
        Console.Write($"{array[i, j], 4},");
    }
    Console.WriteLine("]");
}
Console.WriteLine();

if (findM >= m || findN >= n) Console.WriteLine($"По координатам [{findM}, {findN}] элемента в массиве нет ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == findM && j == findN) Console.WriteLine($"По координатам [{findM}, {findN}] находится число {array[i,j]}");
    }
}
