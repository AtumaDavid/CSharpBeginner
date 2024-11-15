﻿using System;
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

            // Exercise - Times table

            // three
            //Ask the user for a number for thhe table...
            //Write a for loop to print X times table
            Console.Write("Enter Number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("{0} x {1} = {2}", i, numberTwo, i * numberTwo);
            }

            // Exercise - Fizz Buzz game
            //four
            /*
             *  create a for loop from 1 to X (15)
             *  if divisible by 3 and 5 = FizzBuzz...
             *  3 = Fizz
             *  5 = Buzz
             *  else = number
             */
            bool threeDiv = false;
            bool fiveDiv = false;

            for (int i = 1; i <= 15; i++) {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv) {
                    Console.WriteLine("Fizz");
                } 
                else if (fiveDiv) {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Exercise - Print string in reverse
            // five
            /*
             * Ask use to input message
             * print in order
             * print in reverse
             */
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            //Console.WriteLine(message[0]);
            //Console.WriteLine(message.Length);

            for (int i = 0; i < message.Length; i++) // 0-13
            {
                Console.Write(message[i]);
            }

            for (int i = message.Length - 1; i >= 0; i--) // 13-0
            {
                Console.Write(message[i]);
            }

            // Exrcise - Password checker
            // six
            /*
             * Ask user to enter password and store
             * Ask user to enter password again, and store
             * Check if they are both contain something
             * -- If so, check if they are the same
             * --   -- If they are, Print "Password match"
             * --   -- If they are not, Print "Password do not match"
             * -- If they are empty, print "please enter a password"
             */

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            
            Console.Write("Enter Password again: ");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty) ) 
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if (password.Equals(passwordC))
                    {
                        Console.WriteLine("passwords match");
                    }
                    else
                    {
                        Console.WriteLine("Passwords do not match");
                    }
                } 
                else
                {
                    Console.WriteLine("Please enter a password confirmation");
                }
            }
            else
            {
                Console.WriteLine("Please enter a password.");
            }

            // Exrcise - Odd/Even Number Split
            // seven
            /*
             * Create two lists with integer data types, one for even numbers and one for odd numbers
             * Loop from 0 to 20
             *  -- If number is even, add to even list
             *  -- If number is odd, add to odd list
             * Print even list
             * Print odd list
             */
            List<int> odd = new List<int>();
            List<int>  even = new List<int>();

            for (int i = 0; i <= 20; i++) {
                if (i % 2 == 0) {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }
            Console.WriteLine("Printing even numbers: ");
            foreach(var item in even)
            {
                Console.WriteLine($"{item}"); 
            }

            Console.WriteLine("Printing odd numbers: ");
            foreach (var item in odd)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadLine();
        }
    }
}
