using System;

class Program
{
    static void Main()
    {
        // Input base1, base2, and height
        Console.Write("Enter the length of base 1: ");
        int b1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the length of base 2: ");
        int b2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the height: ");
        int h = int.Parse(Console.ReadLine());

        // Calculate the area of the trapezoid
        double areaValue = (b1 + b2) / 2.0 * h;

        // Output the area
        Console.WriteLine($"Trapezoid area: {areaValue} square meters");
    }
}