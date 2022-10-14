// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N с помощью рекурсии
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Console.Clear();

// Console.WriteLine("Введите целочисленные значения: ");
// Console.Write("M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void NaturalNumber(int m, int n)
// {
//     if (m == n) 
//     {
//         Console.Write($"{m} "); 
//         return;
//     }
//     if (m > n)
//     {
//         Console.Write($"{m} ");
//         NaturalNumber(m - 1, n);
//     }
//     else 
//     {
//         NaturalNumber(m, n - 1);
//         Console.Write($"{n} ");
//     }
// }
// NaturalNumber(m, n);

// вариант 2

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int m, int n)
{

    if (m == n)
    {
        Console.Write($"{n}, ");
        return;
    }
    if (m > n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m - 1, n);
    }
    else
    {
        NaturalNumber(m, n - 1);
        Console.Write($"{n}, ");
    }

}
NaturalNumber(m, n);


