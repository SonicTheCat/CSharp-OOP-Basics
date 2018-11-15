using System;
using System.Linq;

public class Engine
{
    private IReader reader;
    private IWriter writer;
    private DraftManager manager;

    public Engine(IReader reader, IWriter writer, DraftManager manager)
    {
        this.reader = reader;
        this.writer = writer;
        this.manager = manager;
    }
    
    public void Run()
    {
        while (true)
        {
            var tokens = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var command = tokens[0];

            switch (command)
            {
                case "RegisterHarvester":
                    writer.WriteLine(manager.RegisterHarvester(tokens.Skip(1).ToList()));
                    break;
                case "RegisterProvider":
                    writer.WriteLine(manager.RegisterProvider(tokens.Skip(1).ToList()));
                    break;
                case "Day":
                    writer.WriteLine(manager.Day());
                    break;
                case "Mode":
                    writer.WriteLine(manager.Mode(tokens.Skip(1).ToList()));
                    break;
                case "Check":
                    writer.WriteLine(manager.Check(tokens.Skip(1).ToList()));
                    break;
                case "Shutdown":
                    writer.WriteLine(manager.ShutDown());
                    return;
            }
        }
    }
}