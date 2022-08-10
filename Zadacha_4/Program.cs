// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Программа нахождения большего числа из трех:");

Console.Write("Введите число a: ");

string numberString = Console.ReadLine();
int numbera = int.Parse(numberString);

Console.Write("Введите число b: ");

string numberStringa = Console.ReadLine();
int numberb = int.Parse(numberStringa);

Console.Write("Введите число c: ");

string numberStringb = Console.ReadLine();
int numberc = int.Parse(numberStringb);

int max = numbera;

if (numbera > max) max = numbera;
if (numberb > max) max = numberb;
if (numberc > max) max = numberc;

Console.Write("Наибольшее число = ");
Console.WriteLine(max);