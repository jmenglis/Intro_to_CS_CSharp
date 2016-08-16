using System;

namespace IntroCS {
    class Cartesian {
        static string PartofPlane(int x, int y) {
            if (x == 0) {
                if (y == 0) {
                    return "origin";
                } else {
                    return "y axis";
                }
            } else if (y == 0) {
                return "x axis";
            } else if (y > 0) {
                if (x > 0) {
                    return "quadrant I";
                } else {
                    return "quadrant II";
                }
            } else {
                if (x < 0 ) {
                    return "quadrant III";
                } else {
                    return "quandrant IV";
                }
            }
        } 
        public static void Main() {
            Console.WriteLine (PartofPlane (
                UIF.PromptInt ("Integer X: "),
                UIF.PromptInt ("Integer Y: ")));
        }
    }
}
