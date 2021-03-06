﻿using System;

namespace IntroCS {
    class Wages {
        /// Return the total weekly wages for a working
        /// totalHours with a given regular hourlyWage
        /// Include overtime for hours over 40.
        static double CalcWeekWages(double totalHours, double hourlyWage) {
            double regularHours, overtime;
            if (totalHours <= 40) {
                regularHours = totalHours;
                overtime = 0;
            } else {
                regularHours = 40;
                overtime = totalHours - 40;
            }
            return hourlyWage * regularHours + (overtime * (1.5 * hourlyWage));
        }
        static void Main() {
            double hours = UIF.PromptDouble("Enter hours worked: ");
            double wage = UIF.PromptDouble("Enter dollars paid per hour: ");
            double total = CalcWeekWages(hours, wage);
            Console.WriteLine("Wages for {0} hours at {1:F2} per hour are {2:F2}.", hours, wage, total);
        }
    }
}