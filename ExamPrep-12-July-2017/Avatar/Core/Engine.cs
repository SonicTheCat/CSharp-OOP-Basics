using System;
using System.Linq;

public class Engine
{
    IReader reader;
    IWriter writer;
    NationsBuilder builder;

    public Engine(IReader reader, IWriter writer, NationsBuilder builder)
    {
        this.reader = reader;
        this.writer = writer; 
        this.builder = builder;
    }

    public void Run()
    {
        while (true)
        {
            var tokens = this.reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var command = tokens[0];

            switch (command)
            {
                case "Bender":
                    {
                        this.builder.AssignBender(tokens.Skip(1).ToList());
                    }
                    break;
                case "Monument":
                    {
                        this.builder.AssignMonument(tokens.Skip(1).ToList());
                    }
                    break;
                case "Status":
                    {
                        this.writer.WriteLine(this.builder.GetStatus(tokens[1]));
                    }
                    break;
                case "War":
                    {
                        this.builder.IssueWar(tokens[1]);
                    }
                    break;
                case "Quit":
                    {
                        this.writer.WriteLine(this.builder.GetWarsRecord());
                    }
                    return;
            }
        }
    }
}