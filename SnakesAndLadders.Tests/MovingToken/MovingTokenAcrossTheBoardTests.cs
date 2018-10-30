using Moq;
using NUnit.Framework;

namespace SnakesAndLadders.Tests
{
  public class MovingTokenAcrossTheBoard
  {
    [Test]
    public void WhenTheGameStartsTheTokenIsPlacedOnSquare1()
    {
      var boardPrinter = new Mock<IBoardPrinter>();
      var game = new Game(boardPrinter.Object);
      game.Start();

      game.PrintBoard();

      boardPrinter.Verify(p => p.Print(1));
    }

    [Test]
    public void WhenThePlayerMakesAMovementTheBoardIsUpdated()
    {
      var boardPrinter = new Mock<IBoardPrinter>();
      var game = new Game(boardPrinter.Object);
      game.Move(3);
      game.PrintBoard();
      boardPrinter.Verify(p => p.Print(4));
    }
  }
}