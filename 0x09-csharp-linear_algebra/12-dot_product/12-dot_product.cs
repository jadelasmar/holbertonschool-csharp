using System;
/// <summary>
/// new class vectormath
/// </summary>
class VectorMath
{
    /// <summary>
    /// method to calculate dot product
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>value or -1</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double prod2 = vector1[0] * vector2[0] + vector1[1] * vector2[1];
            return prod2;
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double prod3 = vector1[0] * vector2[0] + vector1[1] * vector2[1] + vector1[2] * vector2[2];
            return prod3;
        }
        else
        {
            return -1;
        }

    }
}