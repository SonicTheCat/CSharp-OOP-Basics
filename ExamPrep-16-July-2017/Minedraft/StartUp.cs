using System;

public class StartUp
{
    public static void Main()
    {
        IReader reader = new ConsoleReader();
        IWriter writer = new ConsoleWriter();
        var manager = new DraftManager();

        var engine = new Engine(reader, writer, manager);
        engine.Run(); 
    }
}