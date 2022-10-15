// Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

// выполнено без рекурсии

Console.Clear();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

void NaturalEvenNumber(int m, int n)
{
    for (int i = n; i <= m; i++)
    {
        if (n == m & i % 2 == 0)
        {
            Console.Write($"{m}, ");
            return;
        }
        if (n == m & i % 2 != 0)
        {
            Console.Write($"нет чётных чисел");
            return;
        }
        if (i % 2 == 0)
        {
            Console.Write(i + ", ");
        }
    }
}
NaturalEvenNumber(m, n);






// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1


// int n = InputInt("Введите положительное число: ");
// int m = 1;
// if (n < 1)
// {
//     Console.WriteLine("Ввели не положительное число");
// }
// Console.WriteLine(NaturalNumber(n, m));

// int NaturalNumber(int n, int m)
// {
//     if (n == m)
//         return n;
//     else
//         Console.Write($"{NaturalNumber(n, m + 1)}, ");
//     return m;
// }

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine()!);
// }


// вариант 2

// Console.Write("Введите число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int number4 = Convert.ToInt32(Console.ReadLine());
// void PrintMN (int number3, int number4) {
//     Console.Write(number3 + ", ");
//     number3++;
//     if (number3 == number4) {
//         Console.Write(number4);
//         return;
//     } else {
//         PrintMN(number3, number4);
//     }
// }
// PrintMN(number3, number4);
