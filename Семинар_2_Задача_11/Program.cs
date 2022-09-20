// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();

int random = new Random().Next(100, 1000);
Console.WriteLine($"Число: {random}");

int numberA = random / 100;
int numberB = random % 10;

Console.Write(numberA);
Console.Write(numberB);

