// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Программа, показывает второе по счету число в трехзначном: ");
Console.Write("Введите трехзначное число:  ");
string? numberString = Console.ReadLine();
int Number = int.Parse(numberString!);

int Digit1 = Number / 100;
int Digit3 = Number % 10;

int result = (Number - (Digit1 * 100) - Digit3) / 10;

Console.WriteLine("Вторым числом является:  " + result);
