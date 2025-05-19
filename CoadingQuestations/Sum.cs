using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoadingQuestations
{
    public class Sum
    {
        public int SumOfNumbers(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number = number / 10;
            }
            return sum;
        }
    }
}
