// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 13 -> 1101

// вариант - 1
Console.Clear();

// Console.Write("Введите число в десятичном формате: ");
// int number = int.Parse(System.Console.ReadLine()!);

// // System.Console.WriteLine(Convert.ToString(number,2); // читерское решение

// Console.Write($"Полученное число {number} в двоичном значении: ");
// List<int> reversenum = new List<int>();
// while (number > 0)
// {
//     reversenum.Add(number % 2);
//     number = number / 2;
// }
// for (int j = reversenum.Count; j > 0; j--)
//     System.Console.Write(reversenum[j - 1]);



// вариант - 2

// Console.Write("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int DecimalToBinary(int num)
// {
//     int res = 0;
//     int mult = 1;
//     while (num > 0)
//     {
//         res += num % 2 * mult;
//         num /= 2;
//         mult *= 10;
//     }
//     return res;
// }
// int result = DecimalToBinary(number);
// Console.WriteLine(result);



// вариант - 3

// int num = 45;

// void DecToBin (int n)
// {
//     if (n == 0) return;
//     DecToBin(n / 2);
//     Console.Write(n % 2);
// }

// DecToBin(num);


// вариант - 4

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"В двоичной системе: {ConvertTo2(num)}");

string ConvertTo2(int num_local)
{
    string s = "";
    while (num_local > 0)
    {
        s = ((num_local % 2 == 0) ? "0" : "1") + s;
        num_local /= 2;
    }
    if (s == "") s = "0";
    return s;
}

