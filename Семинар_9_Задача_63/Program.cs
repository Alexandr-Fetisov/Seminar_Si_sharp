// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N с помощью рекурсии
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

Console.Write("Введите число N: ");
int value = Convert.ToInt32(Console.ReadLine());

recursion();

void recursion()
{
    if (value > 0)
    {
        int outp = value;
        value--;
        recursion();
        Console.Write(" " + outp);
    }
    return;
}

