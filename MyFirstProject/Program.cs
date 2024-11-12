using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise - Storing User Data
            // one
            var name = "David";
            var number = "0123456789";
            var age = 28;

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(age);

            // two
            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2;
            Console.WriteLine(remainder);


            Console.ReadLine();
        }
    }
}
