using System;

/// <summary>
/// new class VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// method to return length of vector
    /// </summary>
    /// <param name="vector"></param>
    /// <returns>length</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            double vec2 = (Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)));
            return Math.Round(vec2, 2);

        }
        else if (vector.Length == 3)
        {
            double vec3 = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2));
            return Math.Round(vec3, 2);
        }
        else return -1;

    }
}