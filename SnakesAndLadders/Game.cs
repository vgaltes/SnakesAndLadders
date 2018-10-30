using System;

namespace SnakesAndLadders
{
  public class Game
  {
    private IBoardPrinter printer;

    public Game(IBoardPrinter printer)
    {
      this.printer = printer;
    }

    public void Start()
    {
      throw new NotImplementedException();
    }

    public void PrintBoard()
    {
      throw new NotImplementedException();
    }
  }
}