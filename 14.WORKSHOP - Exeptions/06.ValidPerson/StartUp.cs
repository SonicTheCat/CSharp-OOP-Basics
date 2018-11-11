using System;

public class StartUp
{
    public static void Main()
    {
        try
        {
           //Person person = new Person("stamat", "stamov", 30);
           //Person person = new Person("", "stamov", 30);
           //Person person = new Person("   ", "stamov", 30);
           //Person person = new Person("a", "stamov", 30);
           //Person person = new Person("stamat", null, 30);
           //Person person = new Person("stamat", "1234", 30);
           //Person person = new Person("stamat", "xaxa", 0);
            Person person = new Person("stamat", "xaxa", -121);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(ArgumentException a)
        {
            Console.WriteLine(a.Message);
        }
        catch(FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }     
    }
}