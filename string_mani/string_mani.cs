using System;

class StringMani {
    static string replaceFirst(string s, string target, string replacement) {
        int targetEndLen = target.Length;
        int targetStartLen = s.IndexOf(target);

        if (s.IndexOf(target) == -1) {
            Console.WriteLine("The string \"{0}\" does not exist!", target);
            return s;
        } else {
            string firstPart = s.Substring(0, targetStartLen);
            string secondPart = s.Substring(targetStartLen + targetEndLen);

            string final = firstPart + replacement + secondPart;
            return final;
        }
    }

    static void Main() {
        string str1 = "It was the best of times.";
        string str2 = "Of times it was the best";

        Console.WriteLine("str1=" + str1);
        Console.WriteLine("str2=" + str2);
        Console.WriteLine();

        Console.WriteLine("Let us do some \"cutting and pasting\" of strings!");
        string str3 = replaceFirst(str1, "best", "worst");
        Console.WriteLine("str3 = str1 with best => worst: " + str3);
        string str4 = replaceFirst(str2, "best", "worst");
        Console.WriteLine("str2 with best => worst: " + str4);
        string str5 = replaceFirst(str3, "warst", "best");
        Console.WriteLine("str3 with worst => best: " + str5);

    }
}