using System;
class HorribleCode
{
    static void Main()
    {
        Console.WriteLine("Hi, I'm well formatted program");
        Console.WriteLine("Numbers and squares:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0} --> {1}", i, i * i);
        }
    }
}