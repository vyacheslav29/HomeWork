// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");

Console.Write("Введите число:  ");
string? numberString = Console.ReadLine();
int Number = int.Parse(numberString!);
int Index = 1;

while (Number >= Index)
{
    var result = Math.Pow(Index, 3);
    Index++;
    Console.WriteLine(result);
}
if (Number <= 0)
{
    Console.WriteLine("Ошибка, введите положительное число (от 1 до N) ");
}