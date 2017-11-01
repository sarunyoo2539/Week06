using System;

class Program
{
    static void Main()
    {
        double myDouble = 9.9d;
        Console.WriteLine(myDouble);

        long myLong = (long)myDouble;
        Console.WriteLine(myLong);

        myDouble = 9e9d;
        Console.WriteLine(myDouble);

        int myInt = (int)myDouble;
        Console.WriteLine(myInt);
        Console.WriteLine(int.MinValue);

    }
}
