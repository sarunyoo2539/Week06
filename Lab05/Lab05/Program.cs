using System;

class Program
{
    static void Main()
    {
        checked
        {
            double d = 5e9d;
            Console.WriteLine(d);
            int i = (int)d;
            Console.WriteLine(i);
        }

    }
}
