// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.
// Исходный массив:
// 9 2 3
// 4 2 4
// 2 6 7
// Результат замены:
// 9 4 2
// 2 2 6
// 3 4 7

// Console.Clear();

// Console.Write("Введите количество строк двумерного массива: ");
// int rowCount = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов двумерного массива: ");
// int columnCount = int.Parse(Console.ReadLine()!);

// //int[,] array = FillArray(rowCount, columnCount);
// //PrintArray(array);

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

// int[,] SwapRowToCol(int[,] matr)
// {
//     int row = matr.GetLength(0);
//     int col = matr.GetLength(1);
//     int[,] newMatr = new int[row, col];
//     if (row == col)
//     {
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; j < col; j++)
//             {
//                 newMatr[j, i] = matr[i, j];
//             }
//         }
//     }
//     else Console.WriteLine("Rows and Colums length are different!");
//     return newMatr;
// }

// int[,] matrix = CreateMatrixRndInt(rowCount, columnCount, 0, 10);
// PrintMatrix(matrix);
// int[,] resMatrix = SwapRowToCol(matrix);
// Console.WriteLine();
// PrintMatrix(resMatrix);



Console.Clear();
int arrayRangeMin = -10;
int arrayRangeMax = 10;

Console.WriteLine("Создаем новый массив.");
int rows = UserInput("\nВведите количество строк: ");
int columns = UserInput("Введите количество столбцов: ");

int[,] array = new int[rows, columns];

CreateArray(array);
WriteArray(array);

int[,] arrayTrans = new int[columns,rows];


try
{
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            arrayTrans[i, j] = array[j, i];
        }
    }
    Console.WriteLine("\n Создаем транспонированый массив: \n");

    WriteArray(arrayTrans);
}

catch
{
    Console.WriteLine("\n Невозможно транспонировать массив. \n");
}


int UserInput(string input)
{
    Console.Write(input);
    int output = int.Parse(Console.ReadLine()!);
    return output;
}

void CreateArray(int[,] array)
{
    Console.WriteLine("\n Массив чисел: \n\t");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(arrayRangeMin, arrayRangeMax);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 5}", array[i, j]);
        }
        Console.WriteLine();
    }
}
