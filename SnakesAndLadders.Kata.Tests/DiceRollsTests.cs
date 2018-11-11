using System;
using FluentAssertions;
using Xunit;

namespace SnakesAndLadders.Kata.Tests
{
    public class DiceRollsTests
    {
        [Fact]
        public void GivenGameIsStarted_WhenPlayerRollsADie_ThenResultShouldBeBetweenOneAndSixInclusive()
        {
            // Arrange
            var validDices= new[] {1, 2, 3, 4, 5, 6};
            var diceRoller = new DiceRoller();

            // Act
            var dice = diceRoller.Roll();

            // Assert
            dice.Should().BeOneOf(validDices);
        }
    }

    public class DiceRoller
    {
        private readonly Random _random = new Random();

        public int Roll()
        {
            return _random.Next(1, 7);
        }
    }
}