// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

int M = 1;

while (N >= M)
{
    if (M % 2 == 0)
    {
        Console.Write(M + " ");
    }

    M++;
}