// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

void FillArray(int[] numbers, int minValue = 100, int maxValue = 1000)
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

int EvenNumbers(int[] numbers)
{
    int amount = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
            amount++;
    }
    return amount;
}

Console.Write("Количесто элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Количество четных элементов " + EvenNumbers(array));