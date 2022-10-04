// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// вариант - 1
Console.Clear();


// System.Console.Write("Введите число: ");
// int number = int.Parse(System.Console.ReadLine()!);
// int i = 1;
// List<int> array = new List<int>() { 0, 1 };
// while (i < number - 1)
// {
//     array.Add(array[i] + array[i - 1]);
//     i++;
// }
// System.Console.WriteLine("Числа Фибоначчи: " + string.Join("|", array));


// вариант - 2


Console.WriteLine();
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine()!);

int[] array = new int[num2];
array[0] = 0;
array[1] = 1;

for (int i = 2; i < num2; i++)
{
    array[i] = array[i-1] + array[i-2];
}

Console.WriteLine("Фибоначи: " + String.Join(", ", array));

