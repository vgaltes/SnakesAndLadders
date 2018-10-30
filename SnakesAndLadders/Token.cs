using System;

namespace SnakesAndLadders
{
  public class Token
  {
    public int Position
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
      Position = toSquare;
    }

    internal void SetAsWinner()
    {
      State = TokenState.Winner;
    }
  }
}