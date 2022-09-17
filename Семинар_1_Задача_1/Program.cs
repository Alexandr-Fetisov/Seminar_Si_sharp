//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.Clear();

Console.Write("Введите число1: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите число2: ");
int number2 = int.Parse(Console.ReadLine());

if (Math.Pow(number1,2) == number2)
{
              Console.WriteLine("а = " + number1 +  ", b = " + number2 + " -> да");
} 
else
{
              Console.WriteLine("а = " + number1 +  ", b = " + number2 + " -> нет");
}


