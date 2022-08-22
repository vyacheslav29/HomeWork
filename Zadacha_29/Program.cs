// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Программа, задаёт массив из 8 элементов");

int[] CreateArray()
{
    int[] array = new int[8];
    var random = new Random();

    for (int i = 0; i < 8; i++)
        array[i] = random.Next(0, 10);
    return array;
}   

var array = CreateArray();

for (int i = 0; i < 8; i++)
    Console.Write(array[i] + ", ");
