// Задача 28_1: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// Задача 28_2: Напишите программу, которая принимает на вход число M и N и выдаёт произведение чисел M до N.
// 2; 4 -> 24, 
// 1; 5 -> 120

void Task28_1()
{
    Console.Write("Введите число: ");
    int N = int.Parse(Console.ReadLine()!);
    int result = 1;

    for (int i = 1; i <= N; i++)
    {
        result *= i;
    }

    Console.WriteLine($"Результат произведения чисел от 1 до {N} равен: {result}");
}

// int resultFor(int M, int N)
// {
//     int result = 1;
//     for (int i = M; i <= N; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }    


void Task28_2()
{
    Console.Write("Введите число M: ");
    int M = int.Parse(Console.ReadLine()!);
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine()!);
    
    int result = 1;
    for (int i = M; i <= N; i++)
    {
        result = result * i;
    }

    Console.WriteLine($"Результат произведения чисел от {M} до {N} равен: {result}");

}

Console.Clear();

Console.WriteLine("Семинар 4");
string Flex = "n";

while (Flex == "n")
{
    Console.Clear();
    Console.Write("Ввведите номер задачи (28_1, 28_2): ");
    string task = Console.ReadLine()!;
    Console.WriteLine();

    switch (task)
    {
        case "28_1":
            Console.WriteLine("Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.");
            Console.WriteLine("Примеры: 4 -> 24, 5 -> 120");
            Console.WriteLine();
            Task28_1();
            break;

        case "28_2":
            Console.WriteLine("Напишите программу, которая принимает на вход число M и N и выдаёт произведение чисел M до N.");
            Console.WriteLine("Примеры: 2; 4 -> 24, 1; 5 -> 120");
            Console.WriteLine();
            Task28_2();
            break;

        default:
            Console.WriteLine("Номер задачи не найден...");
            Console.WriteLine();
            break;
    }
    Console.WriteLine();
    Console.Write("Выйти? (y или n): ");
    Flex = Console.ReadLine()!;
}
