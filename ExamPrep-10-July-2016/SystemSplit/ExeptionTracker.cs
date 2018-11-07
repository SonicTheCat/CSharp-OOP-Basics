using System;

public static class ExeptionTracker
{
    public static void IsValidHardware(Hardware hardware)
    {
        if (hardware == null)
        {
            throw new ArgumentException("Can not register software, because hardware does not exists!"); 
        }
    }

    public static void IsValidSoftware(Software software)
    {
        if (software == null)
        {
            throw new ArgumentException("Given software does not exists!");
        }
    }
}