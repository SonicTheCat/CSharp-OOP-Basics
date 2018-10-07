using System;
using System.Text;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public string Title
    {
        get
        {
           return this.title;
        }
       protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            this.title = value;
        }
    }

    public string Author
    {
        get
        {
            return this.author;
        }
        protected set
        {
            var splitNames = value.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (splitNames.Length > 1 && char.IsDigit(splitNames[1][0]))
            {
                throw new ArgumentException("Author not valid!");
            }
            this.author = value;
        }
    }

    public virtual decimal Price
    {
        get
        {
            return this.price;
        }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            this.price = value;
        }
    }

    public Book(string title, string author, decimal price)
    {
        Author = author;
        Title = title;
        Price = price;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Type: {this.GetType()}");
        sb.AppendLine($"Title: {Title}"); 
        sb.AppendLine($"Author: {Author}"); 
        sb.AppendLine($"Price: {Price:F2}");

        return sb.ToString().TrimEnd();
    }
}