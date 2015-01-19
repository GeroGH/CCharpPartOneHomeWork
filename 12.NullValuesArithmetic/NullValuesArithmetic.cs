using System;

class NullValuesArithmetic
{

    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("Null value of a = " + a);
        Console.WriteLine("Null value of b = " + b);

        a += 7;
        b += 4.5;
        Console.WriteLine("Number + null value of a = " + a);
        Console.WriteLine("Number + null value of b = " + b);

        a = 7;
        b = 4.5;
        Console.WriteLine("Number value of a = " + a);
        Console.WriteLine("Number value of b = " + b);

        a += 10;
        b += 10;
        Console.WriteLine("Number value of a + 10 = " + a);
        Console.WriteLine("Number value of b + 10 = " + b);

    }
}
