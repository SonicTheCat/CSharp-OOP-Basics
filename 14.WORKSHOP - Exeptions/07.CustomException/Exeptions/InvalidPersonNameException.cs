using System;
using System.Runtime.Serialization;

internal class InvalidPersonNameException : FormatException
{
    public InvalidPersonNameException()
    {
    }

    public InvalidPersonNameException(string message) 
        : base(message)
    {
    }

    public InvalidPersonNameException(string message, Exception innerException) 
        : base(message, innerException)
    {
    }

    protected InvalidPersonNameException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }

    public override string Message => "Name must contains only letters!!!!!!!!!!!!!"; 
}