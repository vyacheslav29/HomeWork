// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа, показывает все четные числа от 1 до N:");
Console.Write("Введите число:  ");
string? numberString = Console.ReadLine();
int N = int.Parse(numberString);

int index = 1;

   while(index < N)   
    {
    index++;
    Console.Write("Четные числа в иентервале от 1 до N:  ");
    Console.WriteLine(index++ );
    }
