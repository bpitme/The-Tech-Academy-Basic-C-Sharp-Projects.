using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.");
            Console.ReadLine();
           int package weight = 40;
           int package width = 10;
           int package height= 12;
           int package length = 11;
           if (package weight + package width >10)
                Console.WriteLine(" greter then the 10");
            else
            {
                Console.WriteLine("Package widhth not greter then 10");
            }

            int Your estimated total for shipping this package is: $528.00 Thank you!;
        }

    }
}
