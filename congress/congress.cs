using System;

namespace IntroCS {
    class Congress {
        static string congressCheck(int age, int citizenNum) {
            string officeType;
            if (age >= 30 && citizenNum >= 9) {
                officeType = "Both a Senator or US Representative";
            } else if (citizenNum < 7) {
                officeType = "Neither";
            } else {
                officeType = "US Representative";
            }
            return officeType;
        }
        static void Main() {
            int age = UIF.PromptInt("Please enter the age: ");
            int citizenNum = UIF.PromptInt("Please enter Citizenship length: ");
            Console.WriteLine("The person can be: {0}", congressCheck(age, citizenNum));
        }
    }
}