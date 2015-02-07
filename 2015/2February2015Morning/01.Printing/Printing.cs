using System;

class Printing
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal s = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());
        decimal sumNandS = n * s;
        decimal reams = sumNandS / 500;
        decimal reamsPrice = reams * p;
        Console.WriteLine("{0:F2}", reamsPrice);
    }
}