﻿public static class StartUp
{
    public static void Main()
    {
        ConsoleWindow.CustomizeConsole();

        Wall wall = new Wall(60, 20);
        Snake snake = new Snake(wall);

        Engine engine = new Engine(wall, snake);
        engine.Run();
    }
}