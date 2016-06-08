using System;

namespace IntroCS {
    class Wages {
        /// Return the total weekly wages for a working
        /// totalHours with a given regular hourlyWage
        /// Include overtime for hours over 40.
        static double CalcWeekWages(double totalHours, double hourlyWage) {
            double totalWages;
            if (totalHours <= 40) {
                totalWages = totalHours * hourlyWage;
            } else {
                double overTime = totalHours - 40;
                totalWages = hourlyWage * 40 + (overTime * (hourlyWage * 1.5));
            }
            return totalWages;
        }
        static void Main() {
            double hours = UIF.PromptDouble("Enter hours worked: ");
            double wage = UIF.PromptDouble("Enter dollars paid per hour: ");
            double total = CalcWeekWages(hours, wage);
            Console.WriteLine("Wages for {0} hours at {1:F2} per hour are {2:F2}.", hours, wage, total);
        }
    }
}