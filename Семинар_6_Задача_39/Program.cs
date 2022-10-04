// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// вариант - 1

Console.Clear();

Console.WriteLine("\nВведите массив одной строкой: ");
string num = Console.ReadLine()!;

char[] arr_num = num.ToCharArray();
Array.Reverse(arr_num);
string rev_num = new(arr_num);

Console.WriteLine("\nРеверс массива: {0}", rev_num);

// вариант - 2

// Console.Clear();

// int[] array = FillArray(5, 1, 10);

// Console.WriteLine("Входной массив:" + "[ " + String.Join(",", array) + " ]");

// Console.WriteLine("Перевёрнутый массив: " + "[ " + String.Join(",", ReverseArray(array)) + " ]");

// int[] FillArray(int size, int min, int max)
// {
//     int[] filledArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         filledArray[i] = new Random().Next(min, max + 1);
//     }
//     return filledArray;
// }

// int[] ReverseArray(int[] inputArray)
// {
//     int[] reverseArray = new int[inputArray.Length];

//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         reverseArray[i] = inputArray[inputArray.Length - 1 - i];
//     }
//     return reverseArray;
//}







