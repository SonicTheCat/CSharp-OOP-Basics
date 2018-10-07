using System;

class Program
{
    static void Main()
    {
        var numberOfSongs = int.Parse(Console.ReadLine());
        Playlist playlist = new Playlist();

        for (int i = 0; i < numberOfSongs; i++)
        {
            try
            {
                var song = Console
                   .ReadLine()
                   .Split(";", StringSplitOptions.RemoveEmptyEntries);

                SongValidator.Song(song);

                Track track = new Track(song[0], song[1], song[2]);

                Console.WriteLine("Song added.");
                playlist.Add(track);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine(playlist);
    }
}