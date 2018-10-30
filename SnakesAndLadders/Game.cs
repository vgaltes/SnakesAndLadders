using System;

namespace SnakesAndLadders
{
  public class Game
  {
    private const int LAST_SQUARE = 100;

    private IBoardPrinter printer;
    private IDice dice;

    private Token token = new Token();

    public Game(IBoardPrinter printer)
    {
      this.printer = printer;
    }

    public Game(IBoardPrinter printer, IDice dice)
    {
      this.printer = printer;
      this.dice = dice;
    }

    public void Start()
    {
      token.Move(1);
    }

    public void PrintBoard()
    {
      printer.Print(token);
    }

    public void Move()
    {
      var squaresToMove = dice.Roll();
      Move(squaresToMove);
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