using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoadingQuestations
{
    public class Reverse
    {
        public int ReverseInterger(int number){
            int reverseNumber = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reverseNumber = reverseNumber * 10 + digit;
                number = number / 10;
            }
            return reverseNumber;
        }
        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            int length = charArray.Length - 1;
            string reverseString = "";
            for (int i = length; i >= 0; i--)
            {
                reverseString += charArray[i];
            }
            return reverseString;
        }

        public Array ReverseArray(string[] array)
        {
            return array.Reverse().ToArray();
        }

        

    }
}
