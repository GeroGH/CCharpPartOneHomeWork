//Write an expression that checks for given integer if its third digit from right-to-left is 7
using System;
using System.Collections;
class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Write an expression that checks for given integer if its third digit from right-to-left is 7: ");

        string line = Console.ReadLine();
        char[] array = line.ToCharArray();
        string reverse = String.Empty;
        for (int i = array.Length - 1; i > -1; i--)
        {
            reverse += array[i];
        }
        try
        {
            if ((char)reverse[2] == 55)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("false");
        }
    }
}

