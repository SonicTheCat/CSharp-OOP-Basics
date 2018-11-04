using System;
using System.Threading;
using SimpleSnake.Enums;

public class Engine
{
    private Point[] pointsOfDirection;
    private Direction direction;
    private Snake snake;
    private Wall wall;
    private double sleepTime;

    public Engine(Wall wall, Snake snake)
    {
        pointsOfDirection = new Point[4];
        this.direction = Direction.Right;
        this.wall = wall;
        this.snake = snake;
        this.sleepTime = 100;
    }

    public void Run()
    {
        this.CreateDirections();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                this.GetNextDirection();
            }

            bool isMoving = this.snake.IsMoving(this.pointsOfDirection[(int)direction]);

            if (!isMoving)
            {
                AskUserForRestart();
            }

            sleepTime -= 0.01;

            Thread.Sleep((int)sleepTime);
        }
    }

    private void CreateDirections()
    {
        this.pointsOfDirection[0] = new Point(1, 0);
        this.pointsOfDirection[1] = new Point(-1, 0);
        this.pointsOfDirection[2] = new Point(0, 1);
        this.pointsOfDirection[3] = new Point(0, -1);
    }

    private void GetNextDirection()
    {
        ConsoleKeyInfo userInput = Console.ReadKey();

        if (userInput.Key == ConsoleKey.LeftArrow)
        {
            if (direction != Direction.Right)
            {
                direction = Direction.Left;
            }
        }
        else if (userInput.Key == ConsoleKey.RightArrow)
        {
            if (direction != Direction.Left)
            {
                direction = Direction.Right;
            }
        }
        else if (userInput.Key == ConsoleKey.UpArrow)
        {
            if (direction != Direction.Down)
            {
                direction = Direction.Up;
            }
        }
        else if (userInput.Key == ConsoleKey.DownArrow)
        {
            if (direction != Direction.Up)
            {
                direction = Direction.Down;
            }
        }
    }

    private void AskUserForRestart()
    {
        int leftX = this.wall.LeftX + 1;
        int topY = 3;

        Console.SetCursorPosition(leftX, topY);
        Console.WriteLine("Would you like to continue? y/n");

        string input = Console.ReadLine();

        if (input == "y")
        {
            Console.Clear();
            StartUp.Main();
        }
        else
        {
            StomGame();
        }
    }

    private void StomGame()
    {
        Console.SetCursorPosition(20, 10);
        Console.Write("Game Over!");
        Environment.Exit(0); 
    }
}