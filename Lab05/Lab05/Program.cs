using System;

class Program
{
    static void Main()
    {
        long myLong = long.MaxValue;
        int myInt = (int)myLong;   // Explicit conversion

        float heightInMeters = 1.74f; // Explicit conversion
        double maxHeight = heightInMeters; // Implicit
        double minHeight = (double)heightInMeters; // Explicit
        float actualHeight = (float)maxHeight; // Explicit

        Console.WriteLine(myLong);
        Console.WriteLine(myInt);
        Console.WriteLine(heightInMeters);
        Console.WriteLine(maxHeight);
        Console.WriteLine(minHeight);
        Console.WriteLine(actualHeight);

    }
}
