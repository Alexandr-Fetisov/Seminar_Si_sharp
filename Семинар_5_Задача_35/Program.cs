// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int n = 123; //Console.Write("Введите размер массива: ");
// int arrayLength = int.Parse(Console.ReadLine()!);
int[] array1 = new int[n];

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

int PosEven(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 && arr[i] < 99 )
        counter++;
    }
    return counter;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

int[] array = CreateArray(n, 10, 200);
PrintArray(array);
//Console.WriteLine();
int posEven = PosEven(array);
Console.WriteLine($" -> {posEven}");