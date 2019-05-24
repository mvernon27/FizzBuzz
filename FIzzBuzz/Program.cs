using System;

namespace FIzzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num2 = 0;
            int count = 0;
            for (count = 0; ++count < 100;)
            {
                int num = 0;
                num = num2;
                num2 = (num + 1);

                if (num2 % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (num2 % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (num2 % 5 != 0)
                {
                    if (num2 % 3 != 0)
                    {
                        Console.WriteLine(num2);
                    }
                }                                        
            }
        }
    }
}

