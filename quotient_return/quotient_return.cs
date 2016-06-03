using System;

class QuotientRet {

    static string QuotientString(int x, int y) {
        return string.Format("The quotient of {0} and {1} is {2} with a remainder of {3}.", x, y, x / y, x % y);
    }
    static void Main() {
        Console.Write("Please Enter an Integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please Enter another Integer: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(QuotientString(a, b));
    }

}