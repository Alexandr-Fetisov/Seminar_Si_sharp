// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} -> {i*i*i}");

}

// Console.Write("Введите число: ");
// int num = Math.Abs(int.Parse(Console.ReadLine() ?? "0"));

// for (int i = 1; i <= num; i++)
// {
//     double cube = Math.Pow(i, 3);
//     if (i == num) Console.Write(cube);
//     else
//     {
//         Console.Write(cube + ", ");
//     }
// }