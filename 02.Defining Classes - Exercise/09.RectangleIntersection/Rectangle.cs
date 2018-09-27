using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double horizontal;
    private double vertical;

    public Rectangle(string id, double width, double height, double horizontal, double vertical)
    {
        this.Id = id;
        this.Width = width;
        this.Height = height;
        this.Horizontal = horizontal;
        this.Vertical = vertical;
    }
    public string FindIntersection(Rectangle secondRec)
    {
        if (this.horizontal + this.Width < secondRec.Horizontal
            || secondRec.Horizontal + secondRec.Width < this.horizontal
            || this.vertical + this.Height < secondRec.Vertical
            || secondRec.Vertical + secondRec.Height < this.vertical)
        {
            return "false";
        }
        return "true";
    }
    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }
    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }
    public double Horizontal
    {
        get { return this.horizontal; }
        set { this.horizontal = value; }
    }
    public double Vertical
    {
        get { return this.vertical; }
        set { this.vertical = value; }
    }
}