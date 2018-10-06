using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data = new List<string>();

    public bool IsEmpty()
    {
        return data.Count == 0;
    }

    public void Push(string element)
    {
        data.Add(element);
    }

    public string Pop()
    {
        string element = string.Empty;
        if (!IsEmpty())
        {
            var index = data.Count - 1;
            element = data[index];
            data.Remove(element);

        }
        return element;
    }
    public string Peek()
    {
        string element = string.Empty;
        if (!IsEmpty())
        {
            var index = data.Count - 1;
            element = data[index];
        }
        return element;
    }
}