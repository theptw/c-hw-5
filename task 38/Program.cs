// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] arr = new double[7]{3.5, 32.2, 65.1, 2.4, 23.4, 95.7, 57.9};
double min = arr[0];
double max = arr[0];
double result = 0;



double[] MaxMinDiff(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else
        if (array[i] < min) min = array[i];
    }
    result = max - min;
    return array;
    
} 

void PrintArrResult(double[] array)
{
    for (int k = 0; k < array.Length; k++)
    {
        Console.WriteLine(array[k]);
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result}");
}


MaxMinDiff(arr);
PrintArrResult(arr);

