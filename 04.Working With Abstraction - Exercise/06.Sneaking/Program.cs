using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        Room room = new Room(rows);

        for (int i = 0; i < rows; i++)
        {
            room.Builder(i, Console.ReadLine);
        }

        var directions = Console.ReadLine().ToCharArray();
        room.Sam.Directions = new Queue<char>(directions);

        room.StartMission(); 
    }
}