using System;

class Program
{
    static void Main()
    {
        try
        {
            double d = 5e9d;
            Console.WriteLine(d);
            int i = checked((int)d);
            Console.WriteLine(i);

        }

        catch
        {
            Console.WriteLine("Error, null object assignment.");
        }

    }
}
