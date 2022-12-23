internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());
        while (number < 9999 || number > 100000)
        {
            Console.Write("Введите пятизначное число: ");
            number = int.Parse(Console.ReadLine());
        }
        string palindrome = number.ToString();

        if (palindrome[0] == palindrome[4] && palindrome[1] == palindrome[3])
        {
            Console.WriteLine("Число явлется палиндромом!");
        }
        else
        {
            Console.WriteLine("Число неявлется палиндромом!");
        }
    }
}