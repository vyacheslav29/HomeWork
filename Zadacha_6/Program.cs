﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Программа для проверки, четное или не четное число.");

Console.Write("Введите число, для его проверки: ");
string? numberString = Console.ReadLine();
int numbera = int.Parse(numberString);

if(numbera % 2 == 0)
{
    Console.Write("Введеное число: Четное ");
}

else
{
    Console.Write("Введеное число: Не четное ");
}