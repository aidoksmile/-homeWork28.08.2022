// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}
int max = array[0];
int min = array[0];
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом равна - {max - min}");