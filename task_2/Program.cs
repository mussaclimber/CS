Console.Clear();

Console.Write("Первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Второе число: ");
int numB = int.Parse(Console.ReadLine());
    if (numA > numB) 
    {
	    Console.WriteLine("Первое число больше");
    }
    else 
    {
	    Console.WriteLine("Второе число больше");
    }


// Если введут два одинаковых числа
    /*
    
Console.Write("Первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Второе число: ");
int numB = int.Parse(Console.ReadLine());
 
    if (numA > numB)
    {
        Console.WriteLine("Первое число больше второго");
    }
     else if (numA < numB)
     {
                Console.WriteLine("Первое число меньше второго");
    }
    else
    {
        Console.WriteLine("Оба числа равны");
    }
    */