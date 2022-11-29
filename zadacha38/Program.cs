// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,21 7,04 22,93 -2,71 78,24] -> 80,95

void FillArray(double[] numbers, int minValue = -10, int maxValue = 11)
{
    Random rand = new Random();
    int length = numbers.Length;

    for (int i = 0; i < length; i++)
    {
        numbers[i] = rand.NextDouble() + rand.Next(minValue, maxValue);
    }
}

void PrintArray(double[] numbers)
{
    int length = numbers.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{numbers[i]:f2}" + "  ");
    }
}

double DifferenceBetweenMinAndMax(double[] numbers)
{
    double min = numbers[0];
    double max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
            max = numbers[i];
        else if (numbers[i] < min)
            min = numbers[i];
    }
    double differenceBetweenMinAndMax = max - min;
    return differenceBetweenMinAndMax;
}

Console.Write("Укажите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + ($"{DifferenceBetweenMinAndMax(array):f2}"));
