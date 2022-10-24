// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] Value()
{
    Console.WriteLine("Введите количество чисел: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[Number];
    for (int i = 0; i < Number; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}
int x(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Ответ: " + x(Value()) + " положительных");