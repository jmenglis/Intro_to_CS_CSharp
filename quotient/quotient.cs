using System;

class quotient {
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

        Console.WriteLine("The quotient of " + x + " and " + y + " is " + quo + " with a remainder of " + rem + ".");
    }

}