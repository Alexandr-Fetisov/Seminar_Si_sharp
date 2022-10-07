// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

Console.Write("Введите количество строк двумерного массива: ");
int rowCount = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов двумерного массива: ");
int columnCount = int.Parse(Console.ReadLine()!);


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
            else Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}


int MatrDiagonalSumAlt(int[,] matr)
{
    int sumOfDiagonal = 0;
    int size = matr.GetLength(0);
    if (size > matr.GetLength(1)) size = matr.GetLength(1);
    for (int i = 0; i < size; i++)
    {
        sumOfDiagonal += matr[i,i];
    }
    return sumOfDiagonal;
}

int[,] matrix = CreateMatrixRndInt(rowCount, columnCount, 1, 10);
PrintMatrix(matrix);
int matrDiagonalSum = MatrDiagonalSumAlt(matrix);
Console.WriteLine("Сумма элементов главной диагонали: " + matrDiagonalSum);
