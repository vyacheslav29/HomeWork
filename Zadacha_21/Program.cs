// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");

Console.Write("Введите A1:  ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите A2:  ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите A3:  ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите B1:  ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите B2:  ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите B3:  ");
int z2 = int.Parse(Console.ReadLine()!);

// d = V(x2-x1)2 + (y2-y1)2+ (z2-z1)2
double AB = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)+ (z2 - z1) * (z2 - z1));

Console.WriteLine("Расстояние между точками составляет: " + AB.ToString("N2"));
