// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] createArray()
{
    var random = new Random();
    var result = new double[5];
    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(1, 100);
    }
    return result;
}

void printArray(double[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(" ");
    }
    Console.Write("]");
    Console.WriteLine();
}

var array = createArray();

double min = array[0];
double max = array[0];

for (int i = 1; i < 5; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
    else if (max < array[i])
    {
        max = array[i];
    }
}
    
double difference = max - min;

Console.WriteLine("Сгенерирован массив заполненный случайными числами: ");
printArray(array);

Console.WriteLine();

Console.WriteLine("Разница между максимальным и минимальным элементом массива составляет: ");
Console.WriteLine(difference);