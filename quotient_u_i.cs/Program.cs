using System;
namespace IntroCS {
    class QuotientUI {

        static string QuotientString(int x, int y) {
            return string.Format("The quotient of {0} and {1} is {2} with a remainder of {3}.", x, y, x / y, x % y);
        }
        static void Main() {
            int a = UIF.PromptInt("Please Enter an Integer: ");
            int b = UIF.PromptInt("Please Enter another Integer: ");
            Console.WriteLine(QuotientString(a, b));
        }

    }
}