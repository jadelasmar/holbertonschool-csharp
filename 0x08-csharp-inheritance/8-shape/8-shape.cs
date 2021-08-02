using System;
/// <summary>
/// new class shape
/// </summary>
class Shape
{
    /// <summary>
    /// public virtual method
    /// </summary>
    /// <returns>string</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary>
/// new subclass rectangle iherited from class shape
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    /// <summary>
    /// public method
    /// </summary>
    /// <value>width</value>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }

    /// <summary>
    /// public method
    /// </summary>
    /// <value>height</value>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else { height = value; }
        }
    }
    /// <summary>
    /// public method area
    /// </summary>
    /// <returns>width*height</returns>
    public new int Area()
    {
        return width * height;
    }
    /// <summary>
    /// public method override
    /// </summary>
    /// <returns>string</returns>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}
/// <summary>
/// new subclass square inherited from rectangle
/// </summary>
class Square : Rectangle
{
    private int size;
    /// <summary>
    /// public property
    /// </summary>
    /// <value>size</value>
    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                size = value;
                Height = value;
                Width = value;
            }
        }
    }
}