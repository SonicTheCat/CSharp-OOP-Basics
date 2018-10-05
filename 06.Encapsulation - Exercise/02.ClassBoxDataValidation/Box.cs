using System;

class Box
{
    private double length;
    private double width;
    private double height;

    private double Length
    {
        set
        {
            if (value <= 0)
            {
                ThrowExeption("Length");
            }

            this.length = value;
        }
    }
    private double Width
    {
        set
        {
            if (value <= 0)
            {
                ThrowExeption("Width");
            }

            this.width = value;
        }

    }
    private double Height
    {
        set
        {
            if (value <= 0)
            {
                ThrowExeption("Height");
            }

            this.height = value;
        }
    }


    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public string SurfaceArea()
    {
        double surfaceArea = 2 * length * width + 2 * length * height + 2 * width * height;
        return $"Surface Area - {surfaceArea:F2}";
    }

    public string LateralSurfaceArea()
    {
        double lateralSurfaceArea = 2 * (this.length * this.height) + 2 * (this.width * this.height);
        return $"Lateral Surface Area - {lateralSurfaceArea:F2}";
    }

    public string Volume()
    {
        double volume = this.length * this.width * this.height;
        return $"Volume - {volume:F2}";
    }

    private void ThrowExeption(string name)
    {
        throw new ArgumentException($"{name} cannot be zero or negative.");
    }
}