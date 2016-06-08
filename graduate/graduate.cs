using System;

namespace IntroCS {
    class Graduate {
        static void checkCredits(int credits) {
            if (credits >= 120) {
                Console.WriteLine("Congratulations: You have enough credits to graduate! ");
            } else {
                Console.WriteLine("Sorry: You do not have enough credits to graduate.");
            }
        }
        static void Main() {
            int credits = UIF.PromptInt("Please enter your current credits: ");
            checkCredits(credits);
        }
    }
}