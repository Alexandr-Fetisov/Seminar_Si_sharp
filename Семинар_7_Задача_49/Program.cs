// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 49 2
// 5 9 2 4
// 64 4 4 4

Console.Clear();

Console.Write("Введите количество строк двумерного массива: ");
int rowCount = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов двумерного массива: ");
int columnCount = int.Parse(Console.ReadLine()!);

int[,] array = FillArray(rowCount, columnCount, 1, 10);
PrintArray(array);

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}    


FillArra(array);
int[,] FillArra(int[,] filladArra)
{

    for (int i = 0; i < filladArra.GetLength(0); i++)
    {
        for (int j = 0; j < filladArra.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 )
            {
                filladArra[i, j] = filladArra[i, j] * filladArra[i, j];
            }
        }
    }
    return filladArra;
}
Console.WriteLine();
PrintArray(array);


void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}


