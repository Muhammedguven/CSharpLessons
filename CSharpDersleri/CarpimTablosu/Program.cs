using System;

namespace CarpimTablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + (i * j));
                }

            }
        }
    }
}
