namespace Library;

public class ChessField
{
        private ChessFigure?[,] board;
 
        public ChessField()
        {
            board = new ChessFigure?[8,8];
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
