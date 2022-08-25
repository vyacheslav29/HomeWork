// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//

int[] createArray()
{
    var random = new Random();
    var result = new int[4];
    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(-10, 10);
    }
    return result;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine();
}

var array = createArray();

Console.WriteLine("Сгенерирован массив заполненный случайными числами:");

printArray(array);

Console.WriteLine();

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int pos = IndexOf(array, 1);

int sum_Numbers(int[] array)
{
    var result = 0;
    for (long i = 1; i < array.Length; i = i + 2)
    {
        result += array[i];
    }

    return result;
}

Console.WriteLine();

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях в массиве:");
Console.WriteLine(sum_Numbers(array));
Console.WriteLine();
