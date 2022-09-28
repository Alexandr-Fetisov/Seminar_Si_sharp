// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// Console.Write("Введите число А: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите степень, в которую хотите возвести число "+a+": ");
// double b = Convert.ToDouble(Console.ReadLine());
// double c = Math.Pow(a, b);
// Console.WriteLine("Ответ: "+a+" в степени "+b+" равно "+c+"!");

Console.Clear();
Console.Write("Введите число А: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите степень, в которую хотите возвести число {a}: ");
double b = Convert.ToDouble(Console.ReadLine());

double AvtoDegree(double ac, double bc)
{
    double result = 1;
    for (double i = 0; i < bc; i++)
    {
        result = result * ac;
    }
    return result;

}

double Degree = AvtoDegree(a, b);

Console.WriteLine($"Ответ: {a} в степени {b} равно: {Degree} ");
