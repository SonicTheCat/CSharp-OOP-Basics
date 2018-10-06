using System;
using System.Collections.Generic;

public class RandomList : List<string>
{
    Random rnd = new Random();

    public string RandomString()
    {
        var element = "";
        if (this.Count > 0)
        {
            var index = rnd.Next(0, this.Count - 1);
            element = this[index];
            this.RemoveAt(index);
        }
        return element;
    }
}

