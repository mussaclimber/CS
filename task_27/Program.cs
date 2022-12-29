/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string numberString = number.ToString();
        int sumNumber = 0;

            for (int i = 0; i < numberString.Length; i++)
            {
                sumNumber = sumNumber + Convert.ToInt32(numberString[i].ToString());
            }

        Console.WriteLine(sumNumber);
    }
}