using System;
using System.Collections;

class Program
{
    static void Main()
    {

        Console.WriteLine("Input multiplier: ");
        int x =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Input multiplying: ");
        int y =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"Result =  {RussianMultiplication(x,y)}");
}
    static int RussianMultiplication(int x, int y)
    {
        int sum = 0;

        while (x != 1)
        {
            if ((x % 2) > 0)
            {
                sum += y;
            }
            x = x / 2;
            y *= 2;
        }
        sum += y;
        return sum;
    }
}
