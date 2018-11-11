using FluentAssertions;
using Moq;
using Xunit;

namespace SnakesAndLadders.Kata.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void GivenTokenIsOnSquare97_WhenTokenMove3Spaces_ThenTokenIsOnSquare100AndPlayerIsAWinner()
        {
            // Arrange
            var token = new Token();
            token.Move(96);
            
            var player = new Player(token);

            var diceRollerMock = new Mock<IDiceRoller>();
            diceRollerMock.Setup(roller => roller.Roll()).Returns(3);
            
            // Act
            player.MoveToken(diceRollerMock.Object);

            // Assert
            token.Square.Should().Be(100);
            player.IsWinner.Should().BeTrue();
        }

        [Fact]
        public void GivenTokenIsOnSquare97_WhenTokenMove4Spaces_ThenTokenIsOnSquare97AndPlayerIsNotAWinner()
        {
        }
    }
}