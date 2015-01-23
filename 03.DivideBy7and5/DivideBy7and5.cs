//Write a Boolean expression that checks for given 
//integer if it can be divided (without remainder) by 7 and 5 at the same time.
using System;
class DivideBy7and5
{
    static void Main()
    {
        Console.Write("Input number to try be divided (without remainder) by 7 and 5 at the same time: ");
        string nubmerString = Console.ReadLine();
        int numberReal = 0;
        int.TryParse(nubmerString, out numberReal);
        if (numberReal % 7 == 0 && numberReal % 5 == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

