using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter weight1 : ");
                double w1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter weight2 : ");
                double w2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter high : ");
                double h = Convert.ToDouble(Console.ReadLine());

                Area(w1, w2, h);
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
        static void Area(double w1, double w2, double h)
        {
            double a = ((w1 + w2) * h) * 1 / 2;
            Console.WriteLine("result = {0} cm^2", a);
        }
    }
}

