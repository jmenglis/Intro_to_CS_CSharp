using System;

namespace IntroCS {
    class Grade2 {
        static char letterGrade(double score) {
            char letter;
            if (score < 60) {
                letter = 'F';
            } else if (score < 70) {
                letter = 'D';
            } else if (score < 80) {
                letter = 'C';
            } else if (score < 90) {
                letter = 'B';
            } else {
                letter = 'A';
            }
            return letter;
        }
        static void Main() {
            double g = UIF.PromptDouble("Enter a numerical grade: ");
            Console.WriteLine("Your letter grade is {0}", letterGrade(g));
        }
    }
}