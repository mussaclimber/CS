internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите координату первой точки X: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату первой точки Y: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату первой точки Z: ");
        double z1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату второй точки X: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату второй точки Y: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату второй точки Z: ");
        double z2 = Convert.ToDouble(Console.ReadLine());


        double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

        Console.WriteLine(Math.Round(distance, 3)); 

        Console.WriteLine($"Расстояние между точек  {distance}"); // не знаю как объединить 28-ю и 30-ю строчку чтобы было красиво
    }
}