using System;

class Program
{
    static void Main()
    {
        try
        {
            string author = Console.ReadLine();
            string title = Console.ReadLine();
            decimal price = decimal.Parse(Console.ReadLine());

            Book book = new Book(title, author, price);
            GoldenEditionBook gb = new GoldenEditionBook(title, author, price);
            Console.WriteLine(book + Environment.NewLine);
            Console.WriteLine(gb);

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }
}