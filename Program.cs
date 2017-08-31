using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_stared
{
    class Program
    {
        static void Main(string[] args)
        {
     
            while (true)
            {
                for (long i = 0; i < 100000000; i++)
                {
                    long sum = 1;
                    for (long divisors = (long)Math.Sqrt(i); divisors > 1; divisors--)
                    {
                        if (i % divisors == 0)
                        {
                            sum += divisors;
                            sum += i / divisors;
                        }

                    }
                    if (sum == i)
                        Console.WriteLine(i);
                    if (i % 1000 == 0)
                        Console.Write(i + "\r");
                }
       
            }

        }
    }
}
