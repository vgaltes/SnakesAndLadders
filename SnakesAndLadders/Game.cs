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
      var futureSquare = token.Square + squares;
      if (IsValidMovement(futureSquare))
      {
        token.Move(futureSquare);
      }

      if (HasTokenWin(token))
      {
        token.SetAsWinner();
      }
    }

    private bool HasTokenWin(Token token)
    {
      return token.Square == LAST_SQUARE;
    }

    private bool IsValidMovement(int square)
    {
      return square <= LAST_SQUARE;
    }
  }
}