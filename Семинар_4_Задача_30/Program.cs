// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] numbers;
// int[] nums = new int[8];

int[] Random01(int[] array_local) // с учетом метода, называем Random01
{
    Random rnd = new Random();
    for (int i = 0; i < array_local.Length; i++)
    {
        array_local[i] = rnd.Next(0, 2);
    }

    return array_local;    
}

int[] array = new int[8];
array = Random01(array);
Console.Write(String.Join(",",array)); // метод String.Join добавляет разделители между значениями
