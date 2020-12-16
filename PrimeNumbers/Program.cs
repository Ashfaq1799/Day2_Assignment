using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int  i,j,start=0,stop=0;
            Console.WriteLine("Enter the start value:\t");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the stop value:\t");
            stop = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime Numbers are : ");
            for (i = start; i <= stop; i++)
            {
                for (j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
