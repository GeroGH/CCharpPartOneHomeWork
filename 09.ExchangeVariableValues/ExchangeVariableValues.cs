using System;

class ExchangeVariableValues
{
    static void Main()
    {
        // Може и така но не е за предпочитане
        //int x = 10;
        //int y = 5;
        //x ^= y;
        //y ^= x;
        //x ^= y;
        //Console.WriteLine("X = {0}, Y = {1}", x, y);
        // За това ще прилояим следния начин с 3-та променлива
        int a = 10;
        int b = 5;
        int swap = 0;
        Console.WriteLine("a = {0}, b = {1}", a, b);
        swap = a;
        a = b;
        b = swap;
        Console.WriteLine("a = {0}, b = {1}",a, b);
    }
}

