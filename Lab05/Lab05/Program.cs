using System;

class Program
{
    static void Main()
    {
        byte a = 3;
        byte b = 5;

        Console.WriteLine(a | b);
        Console.WriteLine(a & b);
        Console.WriteLine(a ^ b);
        Console.WriteLine(~a & b);
        Console.WriteLine("{0}", Convert.ToString(a << 1).PadLeft(8, '0'));
        Console.WriteLine("{0}", Convert.ToString(a << 2).PadLeft(8, '0'));
        Console.WriteLine("{0}", Convert.ToString(a >> 1).PadLeft(8, '0'));

    }
}
