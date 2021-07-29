using System;

namespace MyMath
{
    ///<summary>Creation of class Matrix</summary>
    public class Matrix
    {
        ///<summary>Method for dividing matrix by int</summary>
        ///<param name="matrix">2D array of int</param>
        ///<param name="num">denom to divide with</param>
        ///<returns>divided matrix by num</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            else if (matrix == null)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = matrix[i, j] / num;
                    }
                }
                return matrix;
            }
        }
    }
}