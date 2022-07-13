// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[10];
int result = 0;

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
}

void Sum(int[] array)
{
    for (int j = 0; j < array.Length; j+=2)
    {
        result += array[j];
    }
}

void Print(int[] array)
{
    for (int x = 0; x < array.Length; x++)
    {
        Console.WriteLine(array[x]);
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {result}");
}

FillArray(arr);
Sum(arr);
Print(arr);