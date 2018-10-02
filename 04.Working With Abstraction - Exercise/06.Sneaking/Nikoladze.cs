static class Nikoladze
{
    static public int Row;
    static public int Col;

    public static void FindPosition(char[][] matrix)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                if (matrix[row][col] == 'N')
                {
                    Row = row;
                    Col = col;
                }
            }
        }
    }

    public static void SamWon(char[][] matrix)
    {
        matrix[Row][Col] = 'X';
    }
}