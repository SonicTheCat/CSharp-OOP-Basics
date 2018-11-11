using System;
using System.Runtime.Serialization;

internal class InvalidPersonAgeException : ArgumentOutOfRangeException
{
    public InvalidPersonAgeException()
    {
    }

    public InvalidPersonAgeException(string message)
        : base(message)
    {
    }

    public InvalidPersonAgeException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected InvalidPersonAgeException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }

    public override string Message => "Age should be in the range [0...120].";
}