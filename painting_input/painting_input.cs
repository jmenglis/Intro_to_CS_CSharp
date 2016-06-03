using System;

class PaintingInput {
    static string Painting(double length, double width) {
        double wallArea, ceilingArea;
        double HEIGHT = 8;

        wallArea = 2 * (length * width) * HEIGHT;
        ceilingArea = length * width;

        return string.Format("The wall area is {0} square feet.\nThe ceiling area is {1} square feet.", wallArea, ceilingArea);

    }
    static void Main() {
        Console.WriteLine ( "Calculation of Room Paint Requirements");
        Console.Write ( "Enter room length: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write( "Enter room width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine(Painting(length, width));
    }
}