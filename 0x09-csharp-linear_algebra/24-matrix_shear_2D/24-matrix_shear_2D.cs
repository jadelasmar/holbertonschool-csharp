using System;
/// <summary>
/// new matrixmath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method to shear a 2D matrix by factor
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="direction"></param>
    /// <param name="factor"></param>
    /// <returns>new matrix sheared</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (direction == 'x' || direction == 'y' & matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double[,] mat = new double[2, 2];
            double[,] shear =  {
                { 1, 0},
                { 0, 1}
            };
            if (direction == 'x')
            {
                shear[1, 0] = factor;
            }
            else
            {
                shear[0, 1] = factor;
            }
            int row = matrix.GetLength(0);
            int col1 = matrix.GetLength(1);
            int col2 = shear.GetLength(1);
            double[,] mult = new double[row, col2];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    double count = 0;
                    for (int k = 0; k < col1; k++)
                    {
                        count += matrix[i, k] * shear[k, j];

                    }
                    mult[i, j] = count;
                }
            }
            return mult;
        }
        else
        {
            double[,] min1 = { { -1 } };
            return min1;
        }
    }
}