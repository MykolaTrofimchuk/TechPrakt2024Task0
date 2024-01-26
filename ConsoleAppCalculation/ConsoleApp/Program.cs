using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        double a;
        Console.Write("Введіть числа а = ");
        double.TryParse(Console.ReadLine(), out a);

        double b;
        Console.Write("Введіть числа b = ");
        double.TryParse(Console.ReadLine(), out b);

        double summ = a + b;
        Console.WriteLine($"\nСумма введедних чисел: {summ}");
    }
}