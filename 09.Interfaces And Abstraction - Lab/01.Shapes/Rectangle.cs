using System;
using System.Text;

public class Rectangle : IDrawable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public int Width
    {
        get { return this.width; }
        private set { this.width = value; }
    }

    public int Height
    {
        get { return this.height; }
        private set { this.height = value; }
    }

    public void Draw()
    {
        var drawingSymbol = '*';
        var emptySymbol = ' ';

        var builder = new StringBuilder();
        for (int row = 0; row < this.height; row++)
        {
            builder.Append(drawingSymbol);
            if (row == 0 || row == this.height - 1)
            {
                builder.Append(DrawLine(this.width - 2, drawingSymbol));
            }
            else
            {
                builder.Append(DrawLine(this.width - 2, emptySymbol));
            }
            if (this.width >= 2)
            {
                builder.Append(drawingSymbol);
            }
            builder.AppendLine();
        }
        Console.WriteLine(builder.ToString().Trim());
    }

    private string DrawLine(int lineWidth, char symbol)
    {
        var lineBuilder = new StringBuilder();
        for (int i = 0; i < lineWidth; i++)
        {
            lineBuilder.Append(symbol);
        }
        return lineBuilder.ToString();
    }
}