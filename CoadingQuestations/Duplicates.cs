using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoadingQuestations
{
    public class Duplicates
    {
        public List<int> FindDupesIntArrayUsingHashSet(int[] array)
        {
            HashSet<int> hashSet = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();
            foreach(int num in array)
            {
                if (!hashSet.Add(num))
                {
                    duplicates.Add(num);
                }
            }
            return duplicates.ToList();
        }

        public List<string> FindDupesStringArrayUsingHashSet(string[] array)
        {
            HashSet<string> hashset = new HashSet<string>();
            HashSet<string> duplicates = new HashSet<string>();
            foreach (string str in array)
            {
                if (!hashset.Add(str))
                {
                    duplicates.Add(str);
                }
            }
            return duplicates.ToList();
        }

        public List<int> FindDupesUsingLinqQuery(int[] array)
        {
            var duplicates = array.GroupBy(x => x).Where(g => g.Count() > 0).Select(g => g.Key).ToList();
            return duplicates;
        }
    }
}
