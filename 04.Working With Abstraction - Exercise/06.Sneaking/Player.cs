using System;
using System.Collections.Generic;

class Player
{
    public int Row { get; set; }
    public int Col { get; set; }
    public Queue<char> Directions { get; set; }

    public Player()
    {
        Directions = new Queue<char>();
    }

    public void Move(char[][] matrix,char direction)
    {
        matrix[Row][Col] = '.';
        if (direction == 'U')
        {
            Row--;
        }
        else if (direction == 'D')
        {
            Row++;
        }
        else if (direction == 'L')
        {
            Col--;
        }
        else if (direction == 'R')
        {
            Col++;
        }
        matrix[Row][Col] = 'S';
    }

    public void IsAlive(char[][] matrix)
    {
        for (int c = 0; c < Col; c++)
        {
            if (matrix[Row][c] == 'b')
            {
                matrix[Row][Col] = 'X';
                MissionOver($"Sam died at {Row}, {Col}", matrix);
            }
        }
        var cols = matrix[Row].Length - 1;
        for (int c = cols; c > Col; c--)
        {
            if (matrix[Row][c] == 'd')
            {
                matrix[Row][Col] = 'X';
                MissionOver($"Sam died at {Row}, {Col}", matrix);
            }
        }
    }

    public void FindPostion(char[][] matrix)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                if (matrix[row][col] == 'S')
                {
                    this.Row = row;
                    this.Col = col;
                }
            }
        }
    }

    public void MissionOver(string text, char[][] matrix)
    {
        Console.WriteLine(text);
        foreach (var arr in matrix)
        {
            Console.WriteLine(string.Join("", arr));
        }
        Environment.Exit(0);
    }
}