//Write a Boolean expression that checks for given integer if it can be 
//divided (without remainder) by 7 and 5 at the same time.
using System;
class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Input you weight: ");
        string nubmerString = Console.ReadLine();
        double numberReal = 0;
        double.TryParse(nubmerString, out numberReal);
        //Аз така смятам проценти
        numberReal *= 0.17;
        Console.WriteLine("Your weght on the moon will be: {0}",numberReal);
    }
}

