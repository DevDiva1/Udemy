using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyProblems
{
    public class RotationArray
    {
        public static void Main(String[] args)
        {
            // NOTE: The following input values will be used for testing your solution.
            //int[] array1 = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] array2a = { 4, 5, 6, 7, 8, 1, 2, 3 };
            //var result = IsRotation(array1, array2a);
            //int[] array2b = { 4, 5, 6, 7, 1, 2, 3 };
            //result = IsRotation(array1, array2b);
            //int[] array2c = { 4, 5, 6, 9, 1, 2, 3 };
            //// isRotation(array1, array2c) should return false.
            //int[] array2d = { 4, 6, 5, 7, 1, 2, 3 };
            //// isRotation(array1, array2d) should return false.
            //int[] array2e = { 4, 5, 6, 7, 0, 2, 3 };
            //// isRotation(array1, array2e) should return false.
            //int[] array2f = { 1, 2, 3, 4, 5, 6, 7 };
            //// isRotation(array1, array2f) should return true.
        }

        // Implement your solution below.
        public static bool IsRotation(int[] array1, int[] array2)
        {
            int array1Length = array1.Length;
            int array2Length = array2.Length;
            if (array1Length == array2Length)
            {
                //get the Kth position of rotation
                int rotationPoint = lookUp(array1[0], array2);
                if (rotationPoint == -1)
                {
                    return false;
                }
                for (int i = 0; i < array1Length; i++)
                {
                    if (array1[i] != array2[(i + rotationPoint) % array1Length])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;

        }
        public static int lookUp(int item, int[] array2)
        {
            for (int i = 0; i < array2.Length; i++)
            {
                if (item == array2[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
