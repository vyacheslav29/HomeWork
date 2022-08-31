﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString("N2")} ");
        }
        Console.WriteLine();
    }
}

double[,] CreateArrayWithRandomNumbers(int m, int n)
{
    double[,] result = new double[m, n];

    var random = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.NextDouble() * 10;
        }
    }
    return result;
}

Console.WriteLine("Введите число строк (m)");

if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов (n)");

if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Всё плохо");
}
Console.WriteLine("Получен двумерный массив: ");
PrintArray(CreateArrayWithRandomNumbers(m, n));
Console.WriteLine();