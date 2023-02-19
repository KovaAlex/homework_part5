// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = myArray(6);
Console.WriteLine($"[{string.Join(",", array)}] количество четных чисел {GetResult(array)}");

int[] myArray(int size)
{
    var rand = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}

int GetResult(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

