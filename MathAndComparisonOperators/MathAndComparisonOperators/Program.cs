using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //compiler rounds answer down(no decimal/remainder)
            //int quotient = 100 / 17;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemperture = 70;
            int currentTemperture = 70;

            //bool isWarm = currentTemperture <= roomTemperture;
            bool isWarm = currentTemperture != roomTemperture;

            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
