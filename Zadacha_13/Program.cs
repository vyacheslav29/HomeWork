// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Программа, выводит третью цифру заданного числа на экран: ");
Console.Write("Введите число:  ");
string? numberString = Console.ReadLine();
int Number = int.Parse(numberString!);

while(Number > 1000) 
{
Number = Number / 10;
}

if(Number > 99)
{
    int Digit3 = Number % 10;
    int result = Digit3;
    Console.WriteLine("Третьей цифрой заданного Вами числа, является:  " + result);
} 

if(Number <= 99)
{
    Console.WriteLine("Третьей цифры нет!  ");
}
