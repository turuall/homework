// опишите метод, который принимает на вход два числа
// (A и B) и возводит число A в целую степень B.


// 3, 5 -> 243
// 2, 4 -> 16


void Metod(int a, int b)
{
    int sum = a;
    for (int i = 1; i < b; i++)
    {
        sum = sum * a;
    }
    Console.WriteLine( "ответ: " + sum);
}
Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
Metod(a, b);