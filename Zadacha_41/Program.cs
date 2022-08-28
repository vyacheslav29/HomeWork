// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите количество элементов: ");
int digits = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите числа для проверки: ");
int[] array = new int[digits];

for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine()!);
}

int PositiveNumbers(int[] array)
{
    var result = 0;

    for (long i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            result = result + 1;
    }

    return result;
}

Console.WriteLine("Количество введенных вами чисел, которые больше 0 = " + PositiveNumbers(array));
Console.WriteLine();
