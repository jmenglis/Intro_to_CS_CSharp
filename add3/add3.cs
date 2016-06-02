using System;

class Add3 {
    static void Main() {
        Console.Write("Please enter number 1: ");
        string xString = Console.ReadLine();
        Console.Write("Please enter number 2: ");
        string yString = Console.ReadLine();
        Console.Write("Please enter number 3: ");
        string zString = Console.ReadLine();
        // Convert strings to float
        double x = double.Parse(xString);
        double y = double.Parse(yString);
        double z = double.Parse(zString);

        double sum = x + y + z;

        Console.WriteLine("The three numbers have been added to give us: " + sum);       
    }
}