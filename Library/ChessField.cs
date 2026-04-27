namespace Library;

public class ChessField
{
    private ChessFigure?[,] board;
 
    public ChessField()
    {
        board = new ChessFigure?[8,8];
    }


    public void SetPiece(int x, int y, ChessFigure piece)
    {
        board[x, y] = piece;
    }

    public ChessFigure? GetPiece(int x, int y)
    {
        return board[x, y];
    }

    public void MovePiece(int oldX, int oldY, int newX, int newY)
    {
        ChessFigure? piece = board[oldX, oldY];

        if (piece != null)
        {
            board[newX, newY] = piece;
            board[oldX, oldY] = null;
        }
    }
 

    public override string ToString()
    {
        string result = "";

        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                if (board[x, y] != null)
                {
                    result += board[x, y]?.ToString();
                }
                else
                {
                    result += ((x + y) % 2 == 0) ? " " : "#";
                }

                if (x < 7)
                    result += "|";
            }

            result += "\n";

            if (y < 7)
                result += "-+-+-+-+-+-+-+-\n";
        }

        return result;
    }
}
