using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyProblems
{
    public class RotationArray
    {
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
