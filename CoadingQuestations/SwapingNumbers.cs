using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoadingQuestations
{
    public class SwapingNumbers
    {
        public (int,int) SwapNUmberusingtwoVariables(int number1, int number2)
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            return (number1, number2);
        }

        public  (int,int) SwapNumbersUsingtempVariable(int number1, int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
            return (number1, number2);

        }
    }
}
