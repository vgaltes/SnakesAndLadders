using Moq;
using NUnit.Framework;

namespace SnakesAndLadders.Tests
{
  public class MovingTokenAcrossTheBoard
  {
    Mock<IBoardPrinter> boardPrinter;
    Game game;

    [SetUp]
    public void SetUp()
    {
      boardPrinter = new Mock<IBoardPrinter>();
      game = new Game(boardPrinter.Object);
      game.Start();
    }


    [Test]
    public void WhenTheGameStartsTheTokenIsPlacedOnSquare1()
    {
      game.PrintBoard();

      boardPrinter.Verify(p => p.Print(1));
    }

    [Test]
    public void WhenThePlayerMakesAMovementTheBoardIsUpdated()
    {
      var boardPrinter = new Mock<IBoardPrinter>();
      var game = new Game(boardPrinter.Object);
      game.Start();
      game.Move(3);
      game.PrintBoard();
      boardPrinter.Verify(p => p.Print(4));
    }
  }
}