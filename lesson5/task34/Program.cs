

// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

RandomNumber(array);
Print(array);

int count = 0;
for (int x = 0; x < array.Length; x++)
    if (array[x] % 2 == 0)
        count++;

Console.WriteLine($"всего чисел: {array.Length}, из них чётных: {count}");
void RandomNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");

    }
}