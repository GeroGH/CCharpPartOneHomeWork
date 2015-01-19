using System;

class DeclareVariables
{
    static void Main()
    {
        // За да проверим стоиностите на променливите можем да използваме следните препратки
        // F12 Go to definition
        // Alt+F12 Peek efinition 
        byte p0 = 97;
        sbyte p1 = 115;
        short p2 = -10000;
        ushort p3 = 52130;
        int p4 = 4825932;
        Console.WriteLine("P0 = {0}, P1 = {1}, P2 = {2}, P3 = {3}, P4 = {4}", p0, p1, p2, p3, p4);
    }
}
