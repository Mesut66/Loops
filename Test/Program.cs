using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal principalAmount = 1000;
            decimal rateOfInterest = 7.5m;
            decimal periods = 5;

            decimal compoundInterest = principalAmount * (decimal)(Math.Pow((double)(1 + (rateOfInterest / 100)), (double)periods) - 1);

            Console.WriteLine(compoundInterest);

            Console.ReadKey();
            
        }
    }
}
