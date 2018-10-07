using System;
using System.Linq;

class Track
{
    private string artist;
    private string song;
    private string length;

    public string Artist
    {
        get => this.artist;
        set
        {
            SongValidator.AuthorName(value);
            this.artist = value; 
        }
    }

    public string Song
    {
        get => this.song;
        set
        {
            SongValidator.SongName(value);
            this.song = value;
        }
    }

    public string Length
    {
        get => this.length;
        set
        {
            SongValidator.LengthFormat(value);

            var tokens = value
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            SongValidator.Minutes(tokens[0]);
            SongValidator.Seconds(tokens[1]);

            var lengthInSeconds = (tokens[0] * 60) + tokens[1];
            this.length = lengthInSeconds.ToString();
        }
    }

    public Track(string artist, string song, string length)
    {
        Artist = artist;
        Song = song;
        Length = length;
    }
}