//Write an expression that checks if given integer is odd or even.
using System;
class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Input integer :");
        string nubmerString = Console.ReadLine();
        int numberReal = 0;
        int.TryParse(nubmerString, out numberReal);
        if (numberReal % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}