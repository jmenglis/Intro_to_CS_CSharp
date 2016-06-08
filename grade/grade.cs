using System;

namespace IntroCS {
    class Grade {
        static char letterGrade(double score) {
            char letter;
            if (score >= 90) {
                letter = 'A';
            } else if (score >= 80) {
                letter = 'B';
            } else if (score >= 70) {
                letter = 'C';
            } else if (score >= 60) {
                letter = 'D';
            } else {
                letter = 'F';
            }
            return letter;
        }
        static void Main() {
            double g = UIF.PromptDouble("Enter a numerical grade: ");
            Console.WriteLine("Your letter grade is {0}", letterGrade(g));
        }
    }
}