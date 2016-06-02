using System;

class DoTheMath {
    static void Main() {
        Console.Write("Please enter the numerator? ");
        string numString = Console.ReadLine();
        Console.Write("Please enter the denominator? ");
        string denString = Console.ReadLine();

        // Convert String to Double
        double num = double.Parse(numString);
        double den = double.Parse(denString);
        int numInt = (int)num;
        int denInt = (int)den;

        Console.WriteLine("Integer division result = {0} with a remainder of {1}", numInt / denInt, (int)num % den);
        Console.WriteLine("Floating point division result = {0}", num / den);
        Console.WriteLine("The result as a mixed fraction is {0} {1}/{2}", numInt / denInt, (int)num % den, den);
    }
}