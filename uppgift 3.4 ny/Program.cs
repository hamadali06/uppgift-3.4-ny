using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vänligen ange längden på låten i minuter och sekunder:");

        Console.Write("Minuter: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Sekunder: ");
        int s = int.Parse(Console.ReadLine());

        int totalSekunder = (m * 60) + s;

        int minLängd = (2 * 60) + 45;
        int maxLängd = (4 * 60) + 20;

        if (totalSekunder >= minLängd && totalSekunder <= maxLängd)
        {
            Console.WriteLine("Låten får spelas på radiostationen.");
        }
        else
        {
            Console.WriteLine("Låten får inte spelas på radiostationen.");
        }
    }
}