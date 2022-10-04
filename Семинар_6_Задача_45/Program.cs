// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// вариант - 1

// Console.Clear();

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//     }
//     Console.Write(array[array.Length - 1]);
//     Console.WriteLine("]");
// }

// int[] arr = CreateArrayRndInt(8, 0, 10);
// PrintArray(arr);

// int[] CopyArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         newArray[i] = array[i];
//     }
//     return newArray;
// }

// int[] newArray = CopyArray(arr);
// PrintArray(newArray);



// вариант - 2

Console.Clear();

Console.WriteLine("\nВведите размер массива: ");
int arr_size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[arr_size];
int[] arr_copy = new int[arr_size];

Random rnd = new Random();
for (int i = 0; i < arr_size; i++)
{
    arr[i] = rnd.Next(1, 99);
}

for (int i = 0; i < arr_size; i++)
{
    arr_copy[i] = arr[i];
}

Console.WriteLine(" " + String.Join(", ", arr));
Console.WriteLine(" " + String.Join(", ", arr_copy));

