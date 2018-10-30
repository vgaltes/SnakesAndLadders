using Moq;
using NUnit.Framework;

namespace SnakesAndLadders.Tests
{
  public class PlayerCanWinTheGame
  {
    const int LAST_SQUARE = 100;

    [Test]
    public void WhenThePlayerGetsToTheLastSquareSheWinsTheGame(){
      var boardPrinter = new Mock<IBoardPrinter>();
      var game = new Game(boardPrinter.Object);
      game.Start();

      game.Move(LAST_SQUARE - 4);
      game.Move(3);
      game.PrintBoard();

      boardPrinter.Verify(p => p.Print(It.Is<Token>(t => t.Square == 100 && t.State == TokenState.Winner)));
    }

    [Test]
    public void WhenThePlayerIsSupposedToMoveFurtherThanTheFinalSquareSheDoesNotMove()
    {
      var boardPrinter = new Mock<IBoardPrinter>();
      var game = new Game(boardPrinter.Object);
      game.Start();
      game.Move(LAST_SQUARE - 4);
      game.Move(4);
      game.PrintBoard();

      boardPrinter.Verify(p => p.Print(It.Is<Token>(t => t.Square == 97 && t.State == TokenState.Playing)));
    }
  }

}