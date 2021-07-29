using System;

namespace MyMath
{
    ///<summary>Creation of class matrix</summary>
    public class Matrix
    {
        ///<summary>Creation of class matrix</summary>
        ///<param name="matrix">array of int</param>
        ///<param name="num">num to divide</param>
        ///<returns>new matrix divided</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int[,] newMat = new int[matrix.GetLength(0), matrix.GetLength(1)];
            if (matrix == null)
            {
                return null;
            }
            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        newMat[i, j] = matrix[i, j] / num;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            return newMat;
        }
    }
}