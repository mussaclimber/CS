﻿Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int m = 1;
int i = 2;
for ( i = m; i <= n; i++)
if ( i % 2 == 0)
{
    Console.WriteLine(i);
}
    Console.WriteLine("Это все четные числа из введенного числа");