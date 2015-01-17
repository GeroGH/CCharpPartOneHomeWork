using System;
class CurrentDateAndTime
{
    static void Main()
    {
        // изпозваме "ToString("yyyy.MM.dd")" на края за да изведем 
        // дата в вид на текст и добре форматирана
        Console.WriteLine(DateTime.Now.ToString("yyyy.MM.dd"));
    }
}
