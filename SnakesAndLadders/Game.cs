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
      token.Move(futurePosition);

      if (futurePosition == LAST_SQUARE)
      {
        token.SetAsWinner();
      }
    }
  }
}