using System;

namespace SnakesAndLadders
{
  public class Game
  {
    private IBoardPrinter printer;

    private int tokenPosition = 0;

    public Game(IBoardPrinter printer)
    {
      this.printer = printer;
    }

    public void Start()
    {
      tokenPosition = 1;
    }

    public void PrintBoard()
    {
      printer.Print(tokenPosition);
    }

    public void Move(int squares)
    {
      tokenPosition += squares;
    }
  }
}