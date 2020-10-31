using System;

namespace Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 1; j <= 10; j++)
            {

                for (int i = 1; i <= 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("{0}*{1}={2}\t", i, j, (i * j));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
