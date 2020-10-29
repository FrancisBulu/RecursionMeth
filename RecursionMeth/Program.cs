using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionMeth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal in");
            int c = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine(Factorial(c));
        }
        static int Factorial(int a)
        {
            if (a==1)
            {
                return 1;
            }
            return a * Factorial(a - 1);

        }
    }
}
