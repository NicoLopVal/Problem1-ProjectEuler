using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSum = 0;

            for(int i = 5; i <1000; i = i + 5)
            {
                totalSum = totalSum + i;
            }

            for (int j = 3; j < 1000; j = j + 3)
            {
                if(j%5 != 0)
                    totalSum = totalSum + j;
            }

            Console.WriteLine("Result is: " + totalSum);
        }
    }
}
