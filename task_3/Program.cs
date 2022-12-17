Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
{
	Console.WriteLine("Число является четным");
} 
else
{
	Console.WriteLine("Число является нечетным, введите иное число.");
}