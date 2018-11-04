using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Food : Point
{
    private Random random;
    private Wall wall;
    private char foodSymbol;

    public Food(Wall wall, char foodSymbol, int points)
        : base(wall.LeftX, wall.TopY)
    {
        this.wall = wall;
        this.FoodPoints = points;
        this.foodSymbol = foodSymbol;
        random = new Random();
    }

    public int FoodPoints { get; private set; }

    public void SetRandomPosition(Queue<Point> snakeElements)
    {
        bool isPointOfSnake;

        do
        {
            this.LeftX = random.Next(2, wall.LeftX - 2);
            this.TopY = random.Next(2, wall.TopY - 2);

            isPointOfSnake = snakeElements.Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);

        } while (isPointOfSnake);

        Console.BackgroundColor = ConsoleColor.Red;
        this.Draw(foodSymbol);
        Console.BackgroundColor = ConsoleColor.White;
    }

    public bool IsFoodPoint(Point snake)
    {
        return snake.TopY == this.TopY && snake.LeftX == this.LeftX;
    }
}