using System;

public class StartUp
{
    static void Main()
    {
        TheSystem system = new TheSystem();

        Engine engine = new Engine(system);
        engine.Run(); 
    }
}