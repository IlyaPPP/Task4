/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] array = { 0, 1, 2, 3 };
int max = 0;
int min = 0;
Array();
Max();

Console.Write($"{array[0]}, {array[1]}, {array[2]}, {array[3]} -> {max - min}");

int[] Array()
{
    for (int i = 0; i < 4; i++)
        array[i] = new Random().Next(0, 100);
    return array;
}

void Max()
{
    max = Math.Max(Math.Max(array[0], array[1]), Math.Max(array[2], array[3]));
    min = Math.Min(Math.Min(array[0], array[1]), Math.Min(array[2], array[3]));
}