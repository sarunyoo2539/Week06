using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Compare();
            Console.ReadKey();           
        }
        static void Compare()
        {
            byte dec = 16;
            for (int i = 1; i <= 100; i++)
            {
                if ((i & dec) == dec)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

