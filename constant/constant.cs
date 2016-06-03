using System;

class UseConstant {
    const double PI = 3.14159265358979;

    static double CircleArea(double radius) {
        return PI * radius * radius;
    }

    static double Circumference(double radius) {
        return 2 * PI * radius;
    }

    static void Main() {
        Console.WriteLine("Circle area with radius 5: " + CircleArea(5));
        Console.WriteLine("Circumference with radius 5: " + Circumference(5));
    }
}