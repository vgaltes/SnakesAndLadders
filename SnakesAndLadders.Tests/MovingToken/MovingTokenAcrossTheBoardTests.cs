using Moq;
using NUnit.Framework;

namespace SnakesAndLadders.Tests
{
  public class MovingTokenAcrossTheBoard
  {
    Mock<IBoardPrinter> boardPrinter;
    Mock<IDice> dice;
    Game game;

    [SetUp]
    public void SetUp()
    {
      boardPrinter = new Mock<IBoardPrinter>();
      dice = new Mock<IDice>();
      game = new Game(boardPrinter.Object, dice.Object);
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
      dice.SetupSequence(d => d.Roll()).Returns(3).Returns(4);

      game.Start();
      game.Move();
      game.PrintBoard();
      boardPrinter.Verify(p => p.Print(It.Is<Token>(t => t.Square == 4 && t.State == TokenState.Playing)));

      game.Move();
      game.PrintBoard();
      boardPrinter.Verify(p => p.Print(It.Is<Token>(t => t.Square == 8 && t.State == TokenState.Playing)));
    }
  }
}