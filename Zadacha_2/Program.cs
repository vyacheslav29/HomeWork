//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Программа нахождения большего числа из вдух:");

Console.Write("Введите число a: ");

string numberString = Console.ReadLine();
int numbera = int.Parse(numberString);

Console.Write("Введите число b: ");

string numberStringa = Console.ReadLine();
int numberb = int.Parse(numberStringa);

int max = numbera;

if (numbera > max) max = numbera;
if (numberb > max) max = numberb;

Console.Write("max = ");
Console.WriteLine(max);