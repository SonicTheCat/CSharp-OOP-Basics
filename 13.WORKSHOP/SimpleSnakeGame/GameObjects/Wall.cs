public class Wall : Point
{
    private const char wallSymbol = '\u25A0';

    public Wall(int leftX, int topY)
        : base(leftX, topY)
    {
        this.InitializeWallBorders();
    }

    private void SetHorizontalLine(int topY)
    {
        for (int leftX = 0; leftX < this.LeftX; leftX++)
        {
            this.Draw(leftX, topY, wallSymbol);
        }
    }

    private void SetVerticalLine(int leftX)
    {
        for (int topY = 0; topY < this.TopY; topY++)
        {
            this.Draw(leftX, topY, wallSymbol);
        }
    }

    private void InitializeWallBorders()
    {
        SetHorizontalLine(0);
        SetHorizontalLine(this.TopY);

        SetVerticalLine(0);
        SetVerticalLine(this.LeftX - 1);
    }

    public bool IsPointOfWall(Point snakeNewHead)
    {
        return snakeNewHead.LeftX == 0
            || snakeNewHead.TopY == 0
            || snakeNewHead.LeftX == this.LeftX - 1
            || snakeNewHead.TopY == this.TopY;
    }
}