using System;

class Program
{
    static void Main()
    {
        long c = Factorial(5);
        Console.WriteLine("Factorial of 5 = {0}", c);
        Console.ReadLine();
    }

    static long Factorial(int n)
    {
        if (n == 0)  // Factorial 0 = 1
            return 1;
        return n * Factorial(n - 1);
    }
}
