using System;
class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Input your birthday date in DateTime format: ");
        // пускаме цикъл с който ще проверяваме дали сме вавели дата правилно
        // защото въвеждането за нея е малко по особенно
        // "while (true)" чака "return;" за да спре цикъла до тогава ще се повтаря
        while (true)
            // "try" пробва да изпълни командите в кобите {} докато не срещне
            // проблем от рода на (System.FormatException)
            // тогава с "catch" извеждаме съобщението за повторно попълване на дата
            try
            {
                // пристъпваме към изпълнение на командите първо четем от конзолата
                string birtDatestring = Console.ReadLine();
                // задаваме променлива от типа DataTime "birtDate" и
                // обръщаме стринга "birtDatestring" в DataTime
                DateTime birtDate = Convert.ToDateTime(birtDatestring);
                // теглим от системата DataTime
                DateTime dateNow = DateTime.Now;
                // с TimeSpan получаваме разликата в дни м/у двете дати
                TimeSpan timeSpan = dateNow - birtDate;
                // преобразуваме в години (който съдържат средно по 365.25 дни всяка) и с "Math.Floor"
                // приравняваме до най близкото по малко число за да получим навършените години
                double timeSpanMatFloor = Math.Floor(timeSpan.TotalDays / 365.25);
                // прибавяме на годините 10
                double timeSpanMatFloorPlus10 = timeSpanMatFloor + 10;
                // извейдаме
                Console.WriteLine("Now you are {0} years old.", timeSpanMatFloor);
                Console.WriteLine("After 10 years you will be {0} years old.", timeSpanMatFloorPlus10);
                // горното се изпълнява ако сме въвели правилно годините
                // а ако сме стигнали до този ред то е време да прекратим цикъла с "return;"
                return;
            }
            // "try" пробва да изпълни командите в кобите {} докато не срещне
            // проблем от рода на (System.FormatException)
            // тогава с "catch" извеждаме съобщението за повторно попълване на дата
            catch (System.FormatException)
            {
                System.Console.Write("Input your birthday date in appropriate DateTime format: ");
            }
    }
}