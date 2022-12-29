/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Нельзя использовать функцию Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write($"В какую степень будем возводить число {number}: ");
        int degree = Convert.ToInt32(Console.ReadLine());

        int numberDeg = 1;

        for (int i = 1; i <= degree; i++)
        {
            numberDeg = numberDeg * number;
        }

        Console.WriteLine(numberDeg);
    }
}