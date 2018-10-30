using System;

namespace SnakesAndLadders
{
  public class Token
  {
    public int Square
    {
      get;
      private set;
    }

    public TokenState State
    {
      get;
      private set;
    }

    internal void Move(int toSquare)
    {
      Square = toSquare;
    }

    internal void SetAsWinner()
    {
      State = TokenState.Winner;
    }
  }
}