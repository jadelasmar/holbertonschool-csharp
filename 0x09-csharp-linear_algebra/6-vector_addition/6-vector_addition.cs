using System;
/// <summary>
/// new class VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// method that take 2 vector and add them
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>return addition of 2 vectors</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] vec2 = new double[] { (vector1[0] + vector2[0]), (vector1[1] + vector2[1]) };
            return vec2;
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] vec3 = new double[] { (vector1[0] + vector2[0]), (vector1[1] + vector2[1]), (vector1[2] + vector2[2]) };
            return vec3;

        }
        else
        {
            double[] min1 = new double[] { -1 };
            return min1;
        }

    }
}