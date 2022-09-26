using System;


namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = Convert.ToDouble(Console.ReadLine());

            double L = 2 * 3.14 * R;
            double S = 3.14 * Math.Pow(R, 2);
            Console.WriteLine("{0:0.00} {1:0.00}", L, S);
            Console.ReadKey();

        }
    }
}

