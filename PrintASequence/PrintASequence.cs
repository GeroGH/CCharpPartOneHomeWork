using System;
class PrintASequence
{
    static void Main()
    {
        // инициализираме променлива за първо число от редицата
        int number = 2;
        // инициализираме променлива за максималната стойност на бройката на редицата
        int sequenceNumber = 10;
        // правим цикъл за който да гледа дали не сме прехвърли максималната стойност
        // с "int count = 1" задаваме първа стойност на променливата с която ще следим
        // с "count <= sequenceNumber" проверяваме дали "count" не е по голяма от "sequenceNumber" т.е максималната стойност
        // с "count++" прибавяме по 1 на всяко повторение на цикъла
        for (int count = 1; count <= sequenceNumber; count++)
        {
            // проверяваме дали "number" се дели целочисленно на 2
            if (number % 2 == 0)
            {
                // дели се и проверяваме дали "count" не е по голяма от "sequenceNumber" т.е максималната стойност
                if (count < sequenceNumber)
                {
                    // след като не е по голямо извеждаме "number" без знак защото е четно
                    Console.Write("{0}, ", number);
                    number++;
                }
                else
                    // след като "count" не по малка от "sequenceNumber" т.е максималната стойност
                    // то следва да изведем последната стоиност от редицата
                    Console.WriteLine("{0}", number);
            }
            else
            {
                // не дели и проверяваме дали "count" не е по голяма от "sequenceNumber" т.е максималната стойност
                if (count < sequenceNumber)
                {
                    // след като не е по голямо извеждаме "number" с знак "-" защото е нечетно
                    Console.Write("-{0}, ", number);
                    number++;
                }
                else
                    // след като "count" не по малка от "sequenceNumber" т.е максималната стойност
                    // то следва да изведем последната стоиност от редицата
                    Console.WriteLine("-{0}", number);
            }
        }
    }
}
