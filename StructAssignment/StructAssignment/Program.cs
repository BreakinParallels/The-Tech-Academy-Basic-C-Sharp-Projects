using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create an object of data type Number and assign an amount to it
            Number myNum = new Number();
            myNum.Amount = 3.5m;
            Console.WriteLine(myNum.Amount);
            Console.ReadLine();
        }
        //Create a struct called Number and give it the property “Amount” and have it be of data type decimal.
        public struct Number
        {
            public decimal Amount;
        }
    }
}
