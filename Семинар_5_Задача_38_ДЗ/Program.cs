// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int arrayLength = int.Parse(Console.ReadLine()!);
int[] array1 = new int[arrayLength];

double[] CreateDoubleArray(int size, int max, int roundTo) //max
{
    double[] arr = new double[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(random.NextDouble()*max, roundTo);//arr[i] = random.Next(min, max);
    }
    return arr;
}

double[] MinMax(double[] arr)
{
    double[] res = new double[2];
    
    res[1] = arr[0]; // max
    for (int i = 0; i < arr.Length; i++)
    {
        if(res[1] > arr[i]) continue;
        else res[1] = arr[i];
    }
    res[0] = arr[0]; // min
    for (int i = 0; i < arr.Length; i++)
    {
        if(res[0] < arr[i]) continue;
        else res[0] = arr[i];
    }
    return res;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

double[] array = CreateDoubleArray(arrayLength, 100, 1);
PrintArray(array);
double[] minMax = MinMax(array);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент массива: {minMax[0]}");
Console.WriteLine($"Максимальный элемент массива: {minMax[1]}");
//PrintArray(minMax);
double maxMinDiff = Math.Round(minMax[1] - minMax[0], 2);
Console.WriteLine($"Разница между элементами: {maxMinDiff}");
