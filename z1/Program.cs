/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(0, 100);
    }

    return arr;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;

        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());

int[] array = GetArray(dimension);

SelectionSort(array);
PrintArray(array);
Console.WriteLine($"Рзность Max числа = {array[array.Length - 1]} и Min числа = {array[0]} массива = {array[array.Length - 1] - array[0]}");