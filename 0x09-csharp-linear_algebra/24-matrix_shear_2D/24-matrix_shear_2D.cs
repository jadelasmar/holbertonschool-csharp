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
        int shearX = 0, shearY = 0;

        if (direction == 'x') { shearY = 1; }
        else if (direction == 'y') { shearX = 1; }
        else { return new double[,]{{-1}}; }

        double[,] shearMatrix = new double[,] { 
            {1, shearX * factor},
            {shearY * factor, 1}
        };
        
        if (matrix is double[,] && matrix.GetLength(1) == 2 && matrix.GetLength(0) == 2)
        {
            int rowM1 = matrix.GetLength(0);
            int colM1 = matrix.GetLength(1);
            int colM2 = shearMatrix.GetLength(1);
            int rowM2 = shearMatrix.GetLength(0);

            double[,] mulMatrix = new double[rowM1, colM2];

            for (int col = 0; col < colM1; col++)
            {
                for (int row = 0; row < rowM1; row++)
                {
                    for (int ixj = 0; ixj < colM2; ixj++)
                    {
                        mulMatrix[row, ixj] += matrix[row, col] * shearMatrix[col, ixj];
                    }
                }
            }
            return mulMatrix;
        }
        else  { return new double[,]{{-1}}; }
    }
}