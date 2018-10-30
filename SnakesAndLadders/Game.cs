using System;

namespace SnakesAndLadders
{
  public class Game
  {
    private const int LAST_SQUARE = 100;

    private IBoardPrinter printer;

    private Token token = new Token();

    public Game(IBoardPrinter printer)
    {
      this.printer = printer;
    }

    public void Start()
    {
      token.Move(1);
    }

    public void PrintBoard()
    {
      printer.Print(token);
    }

    public void Move(int squares)
    {
      var futurePosition = token.Position + squares;
      if (IsValidMovement(futurePosition))
      {
        token.Move(futurePosition);
      }

      if (HasTokenWin(token))
      {
        token.SetAsWinner();
      }
    }

    private bool HasTokenWin(Token token)
    {
      return token.Position == LAST_SQUARE;
    }

    private bool IsValidMovement(int square)
    {
      return square <= LAST_SQUARE;
    }
  }
}