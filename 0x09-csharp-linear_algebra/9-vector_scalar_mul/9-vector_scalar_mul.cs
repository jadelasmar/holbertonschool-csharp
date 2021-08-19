using System;
/// <summary>
/// new clas VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// method that multiply vector with a scalar
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="scalar"></param>
    /// <returns>vector</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            double[] vec2 = new double[] { vector[0] * scalar, vector[1] * scalar };
            return vec2;
        }
        else if (vector.Length == 3)
        {
            double[] vec3 = new double[] { vector[0] * scalar, vector[1] * scalar, vector[2] * scalar };
            return vec3;
        }
        else
        {
            double[] min1 = new double[] { -1 };
            return min1;
        }
    }
}