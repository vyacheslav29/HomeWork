// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// "Напишите ЦИКЛ" значит возводить в степень нужно циклом, а не методом Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B");

Console.Write("Введите число A: ");
string? numberString = Console.ReadLine();
int numbera = int.Parse(numberString!);

Console.Write("Введите число B: ");
string? numberStringa = Console.ReadLine();
int numberb = int.Parse(numberStringa!);

int number = numbera;

for (int i = 1; i < numberb; i++)
{
    number = number * numbera;
}

Console.WriteLine("A в степени B = " + number);
