using System;
/// <summary>
/// new class matrixmath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method to rotate matrix by angle
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="angle"></param>
    /// <returns>new matrix</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double[,] mat = new double[2, 2];
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);
            mat[0, 0] = Math.Round((cos * matrix[0, 0]), 2) - Math.Round((sin * matrix[0, 1]), 2);
            mat[0, 1] = Math.Round((sin * matrix[0, 0]), 2) + Math.Round((cos * matrix[0, 1]), 2);
            mat[1, 0] = Math.Round((cos * matrix[1, 0]), 2) - Math.Round((sin * matrix[1, 1]), 2);
            mat[1, 1] = Math.Round((sin * matrix[1, 0]), 2) + Math.Round((cos * matrix[1, 1]), 2);
            return mat;
        }

        else
        {
            double[,] min1 = { { -1 } };
            return min1;
        }

    }
}