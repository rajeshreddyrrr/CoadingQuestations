using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoadingQuestations
{
    public class StringsManipulation
    {
        public Dictionary<string, int> FindOccurrencesOfEachCharacter(string input)
        {
            var occurance = input.GroupBy(c =>c).ToDictionary(g=> g.Key.ToString(),g => g.Count());
            return occurance;
        }

        public string ReverseWordsInSentense(string input)
        {
            return string.Join(" " ,input.Split(" ").Reverse());
        }
    }
}
