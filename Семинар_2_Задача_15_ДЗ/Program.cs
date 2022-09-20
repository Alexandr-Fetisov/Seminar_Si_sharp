﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();

Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <= 7)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Да");
    } 
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Число вне диапозона от 1 до 7");
}