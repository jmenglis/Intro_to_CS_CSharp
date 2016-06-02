using System;

class QuotientFormat {
    static void Main() {
        Console.Write("Please Enter an Integer: ");
        string xString = Console.ReadLine();
        Console.Write("Please Enter another Integer: ");
        string yString = Console.ReadLine();

        // Convert Strings to Int's
        int x = int.Parse(xString);
        int y = int.Parse(yString);
        int quo = x/y;
        int rem = x%y;

        Console.WriteLine("The quotient of {0} and {1} is {2} with a remainder of {3}.", x, y, quo, rem);
    }

}