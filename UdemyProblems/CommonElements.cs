using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UdemyProblems
{
    class CommonElements
    {
        //public static void Main(string[] args)
        //{
        //    var result = FindCommonElements(new int[] {1, 3, 4, 6, 7, 9}, new int[] {1, 2, 4, 5, 9, 10});
        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.ReadKey();
        //}
        public static List<int> FindCommonElements(int[] array1, int[] array2)
        {
            int array1Length = array1.Length;
            int array2Length = array2.Length;
            if (array1Length == 0 || array2Length == 0)
            {
                return null;
            }
            var result = new List<int>();
            if (array1Length < array2Length)
            {
                foreach (var item in array1)
                {
                    bool IsCommonElement = PerformBinarySearch(array2, item);
                    if (IsCommonElement)
                    {
                        result.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in array2)
                {
                    bool IsCommonElement = PerformBinarySearch(array1, item);
                    if (IsCommonElement)
                    {
                        result.Add(item);
                    }
                }
            }
            return result;
        }

        private static bool PerformBinarySearch(int[] lookUpArray, int item)
        {
            int array2Length = lookUpArray.Length;
            int low = 0;
            int high = array2Length;
            
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (lookUpArray[mid] == item)
                {
                    return true;
                }
                if (item < lookUpArray[mid])
                {
                    high = mid;
                }
                else
                {
                    low = mid+1;
                }
            }
            return false;
        }
    }
}
