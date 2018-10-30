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

      boardPrinter.Verify(p => p.Print(It.Is<Token>(t => t.Square == 1 && t.State == TokenState.Playing)));
    }

    [Test]
    public void WhenThePlayerMakesAMovementTheBoardIsUpdated()
    {
      var boardPrinter = new Mock<IBoardPrinter>();
      var game = new Game(boardPrinter.Object);
      game.Start();
      game.Move(3);
      game.PrintBoard();
      boardPrinter.Verify(p => p.Print(It.Is<Token>(t => t.Square == 4 && t.State == TokenState.Playing)));

      game.Move(4);
      game.PrintBoard();
      boardPrinter.Verify(p => p.Print(It.Is<Token>(t => t.Square == 8 && t.State == TokenState.Playing)));
    }
  }
}