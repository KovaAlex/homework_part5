// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = myArray(4);
Console.WriteLine($"[{string.Join(", ", array)}] разница между максимальным и минимальным числом = {(Math.Round(getMax(array) - getMin(array), 2))}");

double[] myArray(int size)
{
    var rand = new Random();
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble(), 2);
    }
    return array;
}

double getMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double getMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}