using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace updated_prime_no
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= i; j++)
                {

                    if (i != j && i % j == 0)
                        break;
                    else if (i == j && i % j == 0)
                        Console.Write("\t" + i);
                }
            }
        }
    }
}

