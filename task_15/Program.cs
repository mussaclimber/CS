internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Введите порядковый номер дня недели");
        int num = int.Parse(Console.ReadLine());

        if (num > 0 && num < 8)
        {
            if (num == 7 || num == 6) // при условии если первый день недели понедельник
            {
                Console.Write($"{num} - это выходной день");
            }
            else
            {
                Console.Write($"{num} - это рабочий день");
            }
        }
        else
        {
            Console.Write(" введите число в пределах от 1 до 7 включительно");
        }
    }
}