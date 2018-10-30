using Moq;
using NUnit.Framework;

namespace SnakesAndLadders.Tests
{
  public class PlayerCanWinTheGame
  {
    const int LAST_SQUARE = 100;
    Mock<IBoardPrinter> boardPrinter;
    Mock<IDice> dice;
    Game game;

    [SetUp]
    public void SetUp() {
      boardPrinter = new Mock<IBoardPrinter>();
      dice = new Mock<IDice>();
      game = new Game(boardPrinter.Object, dice.Object);
      game.Start();
    }

    [Test]
    public void WhenThePlayerGetsToTheLastSquareSheWinsTheGame(){
      dice.SetupSequence(d => d.Roll()).Returns(LAST_SQUARE - 4).Returns(3);

      game.Move();
      game.Move();
      game.PrintBoard();

      boardPrinter.Verify(p => p.Print(It.Is<Token>(t => t.Square == 100 && t.State == TokenState.Winner)));
    }

    [Test]
    public void WhenThePlayerIsSupposedToMoveFurtherThanTheFinalSquareSheDoesNotMove()
    {
      dice.SetupSequence(d => d.Roll()).Returns(LAST_SQUARE - 4).Returns(4);

      game.Move();
      game.Move();
      game.PrintBoard();

      boardPrinter.Verify(p => p.Print(It.Is<Token>(t => t.Square == 97 && t.State == TokenState.Playing)));
    }
  }
}
