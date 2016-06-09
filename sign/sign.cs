using System;

namespace IntroCS {
    class Sign {
        static string numberCat(double num) {
            string category;
            if (num > 0) {
                category = "positive";
            } else if (num < 0) {
                category = "negative";
            } else {
                category = "zero";
            }
            return category;
        }
        static void Main() {
            double number = UIF.PromptDouble("Please enter a number: ");
            Console.WriteLine("{0} is {1}", number, numberCat(number));
        }
    }
}