// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите размер массива: ");
int arrayLength = int.Parse(Console.ReadLine()!);
int[] array = new int[arrayLength];


int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{   Console.Write($"Массив из {arrayLength} элементов: ");
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

int[] createArray = CreateArray(arrayLength, 0, 100);
PrintArray(createArray);