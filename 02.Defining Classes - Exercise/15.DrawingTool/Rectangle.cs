using System;
using System.Collections.Generic;
using System.Text;

class Rectangle : DrawingTool
{
    private int sizeA;
    private int sizeB;

    public Rectangle(int sizeA, int sizeB)
    {
        this.sizeA = sizeA;
        this.sizeB = sizeB;
    }

    public override void Draw()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("|").Append(new string('-', sizeA)).AppendLine("|");

        for (int i = 0; i < this.sizeB - 2; i++)
        {
            sb.Append("|").Append(new string(' ', sizeA)).AppendLine("|");
        }

        if (sizeB > 1)
        {
            sb.Append("|").Append(new string('-', sizeA)).AppendLine("|");
        }

        Console.Write(sb.ToString());
    }
}

