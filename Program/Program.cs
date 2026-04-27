using Library;

namespace Program;

public class Program
{
public static int Main()
{
    ChessField game = new ChessField();

    ChessFigure whiteKing = new
    ChessFigure(4, 0, true, "King");
    ChessFigure blackKing = new
    ChessFigure(4, 7, false, "King");

    game.SetPiece(4, 0, whiteKing);
    game.SetPiece(4, 7, blackKing);

 
    Console.WriteLine(game.ToString());
    return 0;
}
}