using System;

class Interview2 {
    static string InterviewSentence(string name, string time) {
        return string.Format("{0} has an interview at {1}", name, time);
    }
    static void Main() {
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();
        Console.Write("Enter a time: ");
        string time = Console.ReadLine();
        Console.WriteLine(InterviewSentence(name, time));
    }
}