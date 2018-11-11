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
            // Arrange
            var board = new Board();
            var token = new Token();

            // Act
            board.PlaceToken(token);

            // Assert
            token.Square.Should().Be(1);
        }

        [Fact]
        public void GiveTokenIsOnSquareOne_WhenTheTokenIsMovedThreeSpaces_ThenTokenIsOnSquareFour()
        {
            // Arrange
            var board = new Board();
            var token = new Token();
            board.PlaceToken(token);

            // Act
            token.Move(3);

            // Assert
            token.Square.Should().Be(4);
        }
        
        [Fact]
        public void GiveTokenIsOnSquareOne_WhenTheTokenIsMovedThreeSpacesAndThenFourSpaces_ThenTokenIsOnSquareEight()
        {
            // Arrange
            var board = new Board();
            var token = new Token();
            board.PlaceToken(token);

            // Act
            token.Move(3);
            token.Move(4);

            // Assert
            token.Square.Should().Be(8);
        }
    }

    public class Board
    {
        public void PlaceToken(Token token)
        {
            
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