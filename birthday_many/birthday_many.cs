﻿using System;

class BirthdayMany {
    static void HappyBirthday(string person) {
        Console.WriteLine("Happy Birthday to you!");
        Console.WriteLine("Happy Birthday to you!");
        Console.WriteLine("Happy Birthday, dear " + person + ".");
        Console.WriteLine("Happy Birthday to you!");
        Console.WriteLine("");
    }

    static void Main() {
        HappyBirthday("Emily");
        HappyBirthday("Andre");
        HappyBirthday("Maria");
    }
}