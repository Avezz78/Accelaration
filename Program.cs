using System;

namespace classAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;

            for (int n = 1; n < 100; n++)
            {
                for (int i = 2; i < n ; i++)
                {
                    if (n % i == 0)
                    {
                        temp = temp + 1;
                    }
                }
                if (temp == 0)
                {
                    Console.WriteLine(n);

                }
            }
        }
    }
}

