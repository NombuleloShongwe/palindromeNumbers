using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueChecking = true;

            while (continueChecking)
            {
                Console.WriteLine("Enter your lucky number:");
                Console.WriteLine("************************");
                int number = Convert.ToInt32(Console.ReadLine());

                if (IsPalindrome(number))
                {
                    Console.WriteLine("The number " +number+ " is a palindrome.");
                }
                else
                {
                    Console.WriteLine("The number " +number+ " is not a palindrome.");
                }

                Console.WriteLine("Do you want to check another number? (y/n)");
                char choice = Console.ReadKey().KeyChar;

                if (char.ToLower(choice) != 'y')
                {
                    Console.WriteLine("\nPress the spacebar to exit");
                    continueChecking = (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
                }
                Console.WriteLine();
            }
        }

        static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }
    }
}
