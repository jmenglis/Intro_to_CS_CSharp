using System;

class QuotientProb {

    static string QuotientProblem(int x, int y) {
        string sentence = "The quotient of " + x + " and " + y + " is " + x / y + " with a remainder of " + x % y + ".";
        return sentence;
    }
    static void Main() {
        Console.Write("Please Enter an Integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please Enter another Integer: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(QuotientProblem(a, b));
    }

}