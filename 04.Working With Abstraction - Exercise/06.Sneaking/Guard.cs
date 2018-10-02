static class Guard
{
    static public void MoveGuards(char[][] matrix)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                if (matrix[row][col] == 'd')
                {
                    MoveD(matrix, row, col);
                }
                else if (matrix[row][col] == 'b')
                {
                    MoveB(matrix, row, col);
                    col++;
                }
            }
        }
    }

    static private void MoveD(char[][] matrix, int row, int col)
    {
        if (col > 0)
        {
            matrix[row][col] = '.';
            matrix[row][col - 1] = 'd';
        }
        else
        {
            matrix[row][col] = 'b';
        }
    }

    static private void MoveB(char[][] matrix, int row, int col)
    {
        if (col < matrix[row].Length - 1)
        {
            matrix[row][col] = '.';
            matrix[row][col + 1] = 'b';
        }
        else
        {
            matrix[row][col] = 'd';
        }
    }
}