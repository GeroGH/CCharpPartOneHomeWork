using System;
class SquareRoot
{
    static void Main()
    {
        int number = 12345;
        // за да сметнем корен квадратен иползваме "Math.Sqrt"
        // също така използваме double заради "Math.Sqrt"
        double sqrtNumber = Math.Sqrt(number);
        Console.WriteLine(sqrtNumber);
    }
}

