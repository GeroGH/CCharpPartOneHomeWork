//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.
using System;
class FourDigitNumber
{
    static void Main()
    {

        //Не е довършена !!!

        Console.WriteLine("Please input 4 numbers. Press 'ENTER' after each number.");
        string line = Console.ReadLine();
        char[] array = line.ToCharArray();
        int a = Convert.ToInt32(array[0]);
        int b = Convert.ToInt32(array[1]);
        int c = Convert.ToInt32(array[2]);
        int d = Convert.ToInt32(array[3]);
        Console.WriteLine("Sum of digits: {0} {1} {2} {3} ", (char)a, (char)b, (char)c, (char)d);
        Console.WriteLine("Sum of digits: {0} {1} {2} {3} ", (char)d, (char)c, (char)b, (char)a);
        Console.ReadLine();
    }
}
