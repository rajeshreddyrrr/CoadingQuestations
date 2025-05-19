using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoadingQuestations
{
    public class Palindrome
    {

        public bool IsPalindrome(string input)
        {
            string reverse = new string(input.Reverse().ToArray());
            if (input.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsPalindromeWithoutUsingReverse(string input)
        {
            string reverseString = "";
            char[] charArray = input.ToCharArray();
            int length = charArray.Length - 1;
            for (int i = length; i >= 0; i--)
            {
                reverseString += charArray[i];
            }
            if (input.Equals(reverseString, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsPalindromeInteger(int number)
        {
            int originalnumber = number;
            int reverseNumber = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reverseNumber = reverseNumber * 10 + digit;
                number = number / 10;
            }
            if(originalnumber == reverseNumber)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
    }
}
