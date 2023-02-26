/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] array = { 0, 1, 2, 3 };
int pol = 0;
Array();
Pol();

Console.Write($"{array[0]}, {array[1]}, {array[2]}, {array[3]} -> {pol}");

int[] Array()
{
    for (int i = 0; i < 4; i++)
        array[i] = new Random().Next(100, 999);
    return array;
}

void Pol()
{
    for (int i = 0; i < 4; i++)
        if (array[i] % 2 == 0)
            pol += 1;
        else continue;
}