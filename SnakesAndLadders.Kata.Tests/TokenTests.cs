using System;
using FluentAssertions;
using Xunit;

namespace SnakesAndLadders.Kata.Tests
{
    public class TokenTests
    {
        [Fact]
        public void GivenThenGameIsStarted_WhenTokenIsPlacedOnBoard_ThenTokenIsOnSquareOne()
        {
            // Arrange / Act
            var token = new Token();

            // Assert
            token.Square.Should().Be(1);
        }

        [Fact]
        public void GiveTokenIsOnSquareOne_WhenTheTokenIsMovedThreeSpaces_ThenTokenIsOnSquareFour()
        {
            // Arrange
            var token = new Token();

            // Act
            token.Move(3);

            // Assert
            token.Square.Should().Be(4);
        }
        
        [Fact]
        public void GiveTokenIsOnSquareOne_WhenTheTokenIsMovedThreeSpacesAndThenFourSpaces_ThenTokenIsOnSquareEight()
        {
            // Arrange
            var token = new Token();

            // Act
            token.Move(3);
            token.Move(4);

            // Assert
            token.Square.Should().Be(8);
        }
    }

    public class Token
    {
        private int _square = 1;

        public int Square => _square;

        public void Move(int spaces)
        {
            _square += spaces;
        }
    }
}