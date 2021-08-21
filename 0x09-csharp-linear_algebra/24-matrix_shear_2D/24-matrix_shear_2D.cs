using System;
class MatrixMath
{
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
                shear[0, 1] = factor;
            }
            else
            {
                shear[1, 0] = factor;
            }
            mat[0, 0] = (shear[0, 0] * matrix[0, 0]) + (shear[0, 1] * matrix[0, 1]);
            mat[0, 1] = (shear[1, 0] * matrix[0, 0]) + (shear[1, 1] * matrix[0, 1]);
            mat[1, 0] = (shear[0, 0] * matrix[1, 0]) + (shear[0, 1] * matrix[1, 1]);
            mat[1, 1] = (shear[1, 0] * matrix[1, 0]) + (shear[1, 1] * matrix[1, 1]);
            return mat;
        }
        else
        {
            double[,] min1 = { { -1 } };
            return min1;
        }
    }
}