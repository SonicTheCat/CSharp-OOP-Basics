using System;

class Room
{
    private char[][] matrix;
    public Player Sam { get; set; }

    public char[][] Matrix
    {
        get { return matrix; }
        set { matrix = value; }
    }

    public Room(int rows)
    {
        matrix = new char[rows][];
        Sam = new Player(); 
    }

    public void Builder(int row, Func<string> line)
    {
        var col = line().Trim().ToCharArray();
        matrix[row] = col;
    }

    public void StartMission()
    {
        Nikoladze.FindPosition(matrix);
        Sam.FindPostion(matrix);

        while (Sam.Directions.Count > 0)
        {
            Guard.MoveGuards(matrix);
            Sam.IsAlive(matrix);

            var direction = Sam.Directions.Dequeue();
            Sam.Move(matrix, direction);

            if (Sam.Row == Nikoladze.Row)
            {
                Nikoladze.SamWon(matrix);
                Sam.MissionOver("Nikoladze killed!", matrix);
            }
        }
    }
}