// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberstr = Convert.ToString(number);
if (numberstr.Length > 2)
{
  Console.WriteLine("третья цифра  " + numberstr[2]);
}
else if (numberstr.Length < 2)
{
  Console.WriteLine("-> второй цифры нет");
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}