// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает последнюю цифру этого числа.	456 -> 6 782 -> 2 918 -> 8

Console.Write("Введите 3-значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int length = number.ToString().Length;
int result = 0;

if (length == 3)
{
    result = number % 10;
    Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Необходимо 3-значное число!");
}

