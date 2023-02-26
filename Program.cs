/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] array = { 0, 1, 2, 3 };
int summ = 0;
Array();
Nechet();

Console.Write($"{array[0]}, {array[1]}, {array[2]}, {array[3]} -> {summ}");

int[] Array()
{
    for (int i = 0; i < 4; i++)
        array[i] = new Random().Next(-99, 100);
    return array;
}

void Nechet()
{
    for (int i = 0; i < 4; i++)
        if (i % 2 != 0)
            summ += array[i];
        else continue;
}