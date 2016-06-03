using System;

class BadScope {
    public static void Main() {
        int x = 3;
        F();
    }
    static void F() {
        Console.WriteLine(x);
    }
}