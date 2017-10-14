using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyProblems
{
    public class MineSweeper
    {
        //public static void Main(String[] args)
        //{
            // NOTE: The following input values will be used for testing your solution.
            //int[,] bombs1 = { { 0, 2 }, { 2, 0 } };
            //var result = MS(bombs1, 3, 3);

            //Console.Write("]");
            // [[0, 1, -1],
            //  [1, 2, 1],
            //  [-1, 1, 0]]

            //int[,] bombs2 = { { 0, 0 }, { 0, 1 }, { 1, 2 } };
            // mineSweeper(bombs2, 3, 4) should return:
            // [[-1, -1, 2, 1],
            //  [2, 3, -1, 1],
            //  [0, 1, 1, 1]]

            //int[,] bombs3 = { { 1, 1 }, { 1, 2 }, { 2, 2 }, { 4, 3 } };
            // mineSweeper(bombs3, 5, 5) should return:
            // [[1, 2, 2, 1, 0],
            //  [1, -1, -1, 2, 0],
            //  [1, 3, -1, 2, 0],
            //  [0, 1, 2, 2, 1],
            //  [0, 0, 1, -1, 1]]
        //}

        // Implement your solution below.
        public static int[,] MS(int[,] bombs, int numRows, int numCols)
        {
            int[,] field = new int[numRows,numCols];
            //Loop based on length.
            //Assumes each subarray is two elements long.
            for(int k=0; k < field.Length/2;k++)
            {
                int row = bombs[k,0];
                int col = bombs[k,1];

                field[row,col] = -1;
                
                for (int i = row - 1; i < row + 2; i++)
                {
                    for (int j = col - 1; j < col + 2; j++)
                    {
                        //make sure field[i][j] condition is last!
                        if (i >= 0 && i < numRows &&
                            j >= 0 && j < numCols &&
                                field[i, j] != -1)
                        {
                            field[i,j]+=1;
                        }
                    }
                }
            }
            return field;
        }
    }

}
