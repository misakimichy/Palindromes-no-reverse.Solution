using System;
using Palindromes;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a value");
            string input = Console.ReadLine().ToLower();
            Check check = new Check();
            if(check.isPalindrome(input))
            {
                Console.WriteLine("That is a palindrome.");
            }
            else
            {
                Console.WriteLine("That is not a palindrome.");
            }
        }
    }
}
