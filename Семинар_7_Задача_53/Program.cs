// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Изначальный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Итоговый массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

// код необходимо исправлять 

// Console.Clear();

// Console.Write("Введите количество строк двумерного массива: ");
// int rowCount = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов двумерного массива: ");
// int columnCount = int.Parse(Console.ReadLine()!);

// int[,] CreateMatrixRndInt(int row, int col, int min, int max)
// {
//     int[,] matr = new int[row, col];
//     Random rnd = new Random();
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rnd.Next(min, max);
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {

//             if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4}, ");
//             else Console.Write($"{matr[i, j],4} ");

//         }
//         Console.WriteLine("]");
//     }
// }

// void ChangeFirstToLastRow(int[,] matr)
// {
//     int tempF = 0;
//     int tempL = 0;
//     int row = matr.GetLength(0);
//     int col = matr.GetLength(1);
//     for (int i = 0; i < col; i++)
//     {
//         tempF = matr[0, i];
//         tempL = matr[col - 1, i];
//         matr[0, i] = tempL;
//         matr[col - 1, i] = tempF;
//     }
// }

// int[,] matrix = CreateMatrixRndInt(rowCount, columnCount, 0, 10);
// PrintMatrix(matrix);
// ChangeFirstToLastRow(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);

void FillArray(int[,] coll)
{
    Random rnd = new Random();
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = rnd.Next(0, 11);
        }
    }
}

void PrintArray(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            Console.Write($"{coll[i, j],-5}");
        }
        Console.WriteLine();
    }
}

void ChangeFirstLast(int[,] coll, int m, int n)
{
    int j = 0;
    while (j < coll.GetLength(1))
    {
        int temp = coll[0, j];
        coll[0, j] = coll[m - 1, j];
        coll[m - 1, j] = temp;
        j++;
    }
}

Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
ChangeFirstLast(matrix, m, n);
Console.WriteLine();
PrintArray(matrix);