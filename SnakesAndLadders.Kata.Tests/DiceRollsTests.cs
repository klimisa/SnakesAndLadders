using System;
using FluentAssertions;
using Moq;
using Xunit;

namespace SnakesAndLadders.Kata.Tests
{
    public class DiceRollsTests
    {
        [Fact]
        public void GivenGameIsStarted_WhenPlayerRollsADie_ThenResultShouldBeBetweenOneAndSixInclusive()
        {
            // Arrange
            var validDices = new[] {1, 2, 3, 4, 5, 6};
            var diceRoller = new DiceRoller();

            // Act
            var dice = diceRoller.Roll();

            // Assert
            dice.Should().BeOneOf(validDices);
        }

        [Fact]
        public void GivenPlayerRollsAFour_WhenMoveToke_ThenTokenSquareShouldBeFour()
        {
            // Arrange
            var token = new Token();
            var player = new Player(token);

            var diceRollerMock = new Mock<IDiceRoller>();
            diceRollerMock.Setup(roller => roller.Roll()).Returns(4);
            
            // Act
            player.MoveToken(diceRollerMock.Object);

            // Assert
            token.Square.Should().Be(5);
        }
    }

    public class Player
    {
        private readonly Token _token;

        public Player(Token token)
        {
            _token = token;
        }

        public void MoveToken(IDiceRoller diceRoller)
        {
            _token.Move(diceRoller.Roll());
        }
    }

    public interface IDiceRoller
    {
        int Roll();
    }

    public class DiceRoller : IDiceRoller
    {
        private readonly Random _random = new Random();

        public int Roll()
        {
            return _random.Next(1, 7);
        }
    }
}