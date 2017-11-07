using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter First Number : ");
                int val1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter Final Number : ");
                int val2 = Convert.ToInt32(Console.ReadLine());
                Mod7(val1, val2);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }       
        }
        static void Mod7(int val1 ,int val2)
        {
            for (int i = val1; i<= val2; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

