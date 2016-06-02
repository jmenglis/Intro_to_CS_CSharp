using System;

class MyMadLib {
    static void Main() {
        Console.Write("Enter noun: ");
        string noun = Console.ReadLine();
        Console.Write("Enter verb: ");
        string verb = Console.ReadLine();
        Console.Write("Enter color: ");
        string color = Console.ReadLine();
        Console.Write("Enter city: ");
        string city = Console.ReadLine();

        Console.WriteLine("Welcome {0} to the party in {1}!  We love {2} here and to {3}.", noun, city, color, verb);
    }
}