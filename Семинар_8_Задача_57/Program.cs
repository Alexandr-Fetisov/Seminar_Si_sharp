// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

Console.Clear();

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


// void PrintArray(int[] arr)
// {

//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i],2}, ");
//         else Console.Write($"{arr[i],2} ");
//     }
//     Console.WriteLine("]");
// }

// int[] MatrixToArray(int[,] matr)
// {
//     int counter = 0;
//     int[] arr = new int[matr.Length];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             arr[counter] = matr[i, j];
//             counter++;
//         }
//     }
//     return arr;
// }

// void FrequencyIndicator(int[] arr)
// {
//     Array.Sort(arr);
//     PrintArray(arr);
//     int count = 1;
//     int num = arr[0];
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] == num) count++;
//         else
//         {
//             Console.WriteLine($"{num} --> {count}");
//             num = arr[i];
//             count = 1;
//         }
//         if (i == arr.Length - 1) Console.WriteLine($"{num} --> {count}");
//     }
// }


// int[,] matrix = CreateMatrixRndInt(4, 4, 0, 9);
// PrintMatrix(matrix);
// int[] array = MatrixToArray(matrix);
// Console.WriteLine();
// PrintArray(array);
// FrequencyIndicator(array);




// int[,] FillArrayRandom(int rows, int columns, int min, int max)
// {
//     int[,] filledArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             filledArray[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return filledArray;
// }



// void SortArray(int[,] arr_l)
// {
//     int row_l = arr_l.GetLength(0);
//     int col_l = arr_l.GetLength(1);
//     int[] arr_1d = new int[row_l * col_l];
//     int index = 0;
    
//     for (int i = 0; i < row_l; i++)
//     {
//         for (int j = 0; j < col_l; j++)
//         {
//             arr_1d[index] = arr_l[i, j];
//             index++;
//         }
//     }
//     Array.Sort(arr_1d);
//     Console.WriteLine(string.Join(", ", arr_1d));
    
//     PrintData(arr_1d);
    
// }


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
            Console.Write($"{coll[i, j], 4}");
        }
        Console.WriteLine();
    }
}

void PrintDictionary(int[] arr)
{
    Console.WriteLine();
    Console.WriteLine("Dictionary");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void CountElement(int[,] coll, int[] arr)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            arr[coll[i, j]]++;
        }
    }
}
Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
int[] dictionary = new int[10];
FillArray(matrix);
PrintArray(matrix);
PrintDictionary(dictionary);
CountElement(matrix, dictionary);
PrintDictionary(dictionary);