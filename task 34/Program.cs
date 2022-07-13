// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] arr = new int[10];
int result = 0;

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

int[] Calculate(int[] array)
{
    
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0) result++;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int x = 0; x < array.Length; x++)
    {
        Console.WriteLine($"{array[x]} ");
    };
    Console.WriteLine($"В массиве {result} чётных чисел ");
}

FillArray(arr);
Calculate(arr);
PrintArray(arr);