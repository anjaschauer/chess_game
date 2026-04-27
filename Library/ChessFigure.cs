namespace Library;

public class ChessFigure
{
    private int x;
    private int y;
    private bool isWhite;
    private string type;

    public ChessFigure(int x, int y, bool isWhite, string type)
    {
        this.x = x;
        this.y = y;
        this.isWhite = isWhite;
        this.type = type;
    }

    public string GetFigureType()
    {
        return type;
    }

    public bool IsWhite()
    {
        return isWhite;
    }

    public int GetX() => x;
    public int GetY() => y;

    public override string ToString()
    {
        if (type == "King")
        {
            return isWhite ? "K" : "k";
        }
        return "?";
    }

}