// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

void FillArray(int[] numbers, int minValue = -10, int maxValue = 11)
{
    Random rand = new Random();
    int length = numbers.Length;

    for (int i = 0; i < length; i++)
    {
        numbers[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    int length = numbers.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
}

int SumOnOddPosition(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i += 2)
    {
        sum += numbers[i];
    }
    return sum;
}

Console.Write("Укажите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + SumOnOddPosition(array));