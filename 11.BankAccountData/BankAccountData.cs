using System;

class BankAccountData
{
    static void Main()
    {
        string furstName = "Atanas";
        string middleName = "Haralampiev";
        string lastName = "Kralimarkov";
        decimal balance = 100000000000.00m;
        string bankName = "KTB";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        long creditCardOne = 5211256693996029;
        long creditCardTwo = 5211256693996029;
        long creditCardThree = 5211256693996029;

        Console.WriteLine("First name: {0}", furstName);
        Console.WriteLine("Middle name: {0}", middleName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Balance: {0}", balance.ToString("C"));
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit card one: {0}", creditCardOne);
        Console.WriteLine("Credit card two:: {0}", creditCardTwo);
        Console.WriteLine("Credit card three: {0}", creditCardThree);

    }
}
