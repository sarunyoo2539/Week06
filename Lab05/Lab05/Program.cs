using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter weight : ");
                double w1 = Convert.ToDouble(Console.ReadLine());

                weight(w1);
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
        static void weight(double w1)
        {
            double a = (w1 * 1.6);
            Console.WriteLine("Weight = {0} N", a);
        }
    }
}

