internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        double sum = 0;
        
            for (i = 1; i <= n; i++)
            Console.WriteLine(sum = Math.Pow(i, 3));
    }
}