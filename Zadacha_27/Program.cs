// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе");

Console.Write("Введите число:  ");
string? numberString = Console.ReadLine();
int Number = int.Parse(numberString!);

int Digit1 = Number % 10;
int Digit2 = Number % 100 / 10;
int Digit3 = Number % 1000 / 100;
int Digit4 = Number % 10000 / 1000;

int result = (Digit1 + Digit2 + Digit3 + Digit4);
Console.WriteLine("Сумма введеных чисел =  " + result);