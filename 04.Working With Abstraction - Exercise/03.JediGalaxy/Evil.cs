using System.Linq;

class Evil
{
    private int Row { get; set; }
    private int Col { get; set; }

    public Evil()
    {

    }

    public void SetCoordinates(string evilCoords)
    {
        var coords = evilCoords.Split().Select(int.Parse).ToArray();
        Row = coords[0];
        Col = coords[1]; 
    }

    public void DestroyStars(int[][] matrix)
    {
        while (Row >= 0 && Col >= 0)
        {
            if (Row >= 0 && Row < matrix.Length && Col >= 0 && Col < matrix[0].Length)
            {
                matrix[Row][Col] = 0;
            }
            Row--;
            Col--;
        }
    }
}