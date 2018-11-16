public class StartUp
{
    public static void Main()
    {
        IReader reader = new ConsoleReader();
        IWriter writer = new ConsoleWriter();
        NationsBuilder builder = new NationsBuilder();

        Engine engine = new Engine(reader, writer, builder);
        engine.Run();
    }
}