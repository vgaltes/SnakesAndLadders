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
    }
  }
}