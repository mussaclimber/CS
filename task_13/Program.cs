Console.Clear();

Console.WriteLine("Введите число чтобы узнать третью цифру");
int num = int.Parse(Console.ReadLine());
int numA = num;

while (num < 99)
    {
        Console.WriteLine("третьей цифры нет");
		  Console.WriteLine("Введите другое число: ");
		  num = int.Parse(Console.ReadLine());
    }
    {
         if (num >= 100 && num <= 999)
			{
		  	Console.WriteLine($"Третья цифра {num % 10}");
			}
			else
			{
				while (num > 999)
					num = num / 10;
					Console.WriteLine($"Третья цифра {num % 10}");
			}
    }