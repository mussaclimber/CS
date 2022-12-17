Console.Clear();

Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numC = int.Parse(Console.ReadLine());

if (numA > numB && numA > numC)
{
	Console.WriteLine("Первое число самое больше");
}
else if (numB > numA && numB > numC)
{
	Console.WriteLine("Второе число самое больше");
}
else if (numC > numA && numC > numB)
{
	Console.WriteLine("Третье число самое больше");
}