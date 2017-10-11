using System;
using System.Collections;
/*
Find the most frequently occurring item in an array.

Example: The most frequently occurring item in [1, 3, 1, 3, 2, 1] is 1.

If you're given an empty array, you should return null

You can assume that there is always a single, unique value that appears most frequently unless the array is empty.  For instance, you won't be given an array such as [1, 1, 2, 2].

 */

namespace UdemyProblems
{
    class MostFrequent
    {
        //[1,3,1,3,2,1]
        public static int? MostFrequentOccurringNo(int[] input)
        {
            if (input == null || input.Length==0)
            {
                return null;
            }
            if (input.Length == 1)
            {
                return input[0];
            }
            var lookUpTable = new Hashtable();
            var maxCountSoFar = 0;
            var mostOccurringItem = input[0];
            foreach (var item in input)
            {
                if (lookUpTable.ContainsKey(item))
                {
                    var currentCount = (int)lookUpTable[item];
                    lookUpTable[item] = currentCount + 1;
                    if (maxCountSoFar < currentCount + 1)
                    {
                        maxCountSoFar = currentCount + 1;
                        mostOccurringItem = item;
                    }
                }
                else
                {
                    lookUpTable.Add(item, 1);
                }
            }
            return mostOccurringItem;
        }
    }
}
