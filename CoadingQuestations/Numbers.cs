using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoadingQuestations
{
    public  class Numbers
    {
        public int FindHigestNumbers(int num1,int num2,int num3)
        {
            int bigNum = num1;
            if ((num2>bigNum))
            {
                bigNum = num2;
            }
            if (num3 > bigNum)
            {
                bigNum = num3;
            }
            return bigNum;
        }

        public int FindHigestInArray(int[] array)
        {
            int bigNum = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > bigNum)
                {
                    bigNum = array[i];
                }
            }

            return bigNum;
        }

        public (int,int) FindHigestamdLowestInArray(int[] array)
        {
            int bigNum = array[0];
            int lowest = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > bigNum)
                {
                    bigNum = array[i];
                }
                else
                {
                    lowest = array[i];
                }
            }

            return (bigNum,lowest);
        }
    }
}
