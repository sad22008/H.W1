// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-A");
Console.Write("Введите любое число (A): ");
int Number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[Number];

for (int i = 0; i < Number; i++)
{
    array[i] = new Random().Next(Number + 1);
    Console.Write(array[i] + "; ");
}
Console.WriteLine();