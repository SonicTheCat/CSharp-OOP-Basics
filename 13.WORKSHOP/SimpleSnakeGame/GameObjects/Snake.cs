using System;
using System.Collections.Generic;
using System.Linq;

public class Snake
{
    private const char snakeSymbol = '\u25CF';
    private const char emptyspace = ' ';

    private Queue<Point> snakeElements;
    private Food[] foods;
    private Wall wall;
    private int nextLeftX;
    private int nextTopY;
    private int foodIndex;

    public Snake(Wall wall)
    {
        this.snakeElements = new Queue<Point>();
        this.wall = wall;
        this.foods = new Food[3];
        this.foodIndex = RandomFoodNumber;
        this.GetFoods();
        this.CreateSnake();
    }

    public void CreateSnake()
    {
        for (int topY = 1; topY <= 6; topY++)
        {
            this.snakeElements.Enqueue(new Point(2, topY));
        }

        this.foods[this.foodIndex].SetRandomPosition(snakeElements);
    }

    public int RandomFoodNumber => new Random().Next(0, this.foods.Length);

    public void GetFoods()
    {
        this.foods[0] = new FoodAsterisk(this.wall);
        this.foods[1] = new FoodDollar(this.wall);
        this.foods[2] = new FoodHash(this.wall);
    }

    public bool IsMoving(Point direction)
    {
        var snakeHead = this.snakeElements.Last();
        GetNextPoint(direction, snakeHead);

        bool isPointOfSnake = this.snakeElements.Any(x => x.LeftX == this.nextLeftX && x.TopY == this.nextTopY);

        if (isPointOfSnake)
        {
            return false;
        }

        Point snakeNewHead = new Point(this.nextLeftX, this.nextTopY);

        if (this.wall.IsPointOfWall(snakeNewHead))
        {
            return false;
        }

        this.snakeElements.Enqueue(snakeNewHead);
        snakeNewHead.Draw(snakeSymbol);

        if (foods[foodIndex].IsFoodPoint(snakeNewHead))
        {
            this.Eat(direction, snakeHead);
        }

        Point snakeTail = this.snakeElements.Dequeue();
        snakeTail.Draw(emptyspace);

        return true;
    }

    private void Eat(Point direction, Point snakeHead)
    {
        int length = foods[foodIndex].FoodPoints;

        for (int i = 0; i < length; i++)
        {
            this.snakeElements.Enqueue(new Point(this.nextLeftX, this.nextTopY));
            GetNextPoint(direction, snakeHead);
        }

        this.foodIndex = this.RandomFoodNumber;
        this.foods[foodIndex].SetRandomPosition(this.snakeElements);
    }

    public void GetNextPoint(Point direction, Point snakeHead)
    {
        this.nextLeftX = snakeHead.LeftX + direction.LeftX;
        this.nextTopY = snakeHead.TopY + direction.TopY;
    }
}