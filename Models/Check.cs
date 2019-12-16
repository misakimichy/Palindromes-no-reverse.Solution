using System;
using Program;

namespace Palindromes
{
    public class Check
    {
        public bool isPalindrome(string input)
        {
            double length = input.Length;
            for(int i = 0; i < (Math.Floor(length/2)); i++){
                if(!(input[i] == input[Convert.ToInt32(length - (i + 1))])){
                    return false;
                }
            }
            return true;
        }
    }
}