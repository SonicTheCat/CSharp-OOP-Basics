using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        try
        {
            //var result = ConvertStringToDouble("20.09");
            //var result = ConvertStringToDouble(-10);

            //FORMAT EXEPTION:
            //var result = ConvertStringToDouble("string");

            //INVALID CAST EXEPTIONS: 
            //var result = ConvertStringToDouble('2');
            //var result = ConvertStringToDouble(new List<int>());

            //OVERFLOW EXEPTION: 
            var d = decimal.MaxValue;
            var result = ConvertStringToDouble(d * d);

            Console.WriteLine(result);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (InvalidCastException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (OverflowException oe)
        {
            Console.WriteLine(oe.StackTrace);
        }
        finally
        {
            Console.WriteLine("We are in the finnaly block. It will be executed every time! ");
        }
    }

    static double ConvertStringToDouble<T>(T value)
    {
        return Convert.ToDouble(value);
    }
}