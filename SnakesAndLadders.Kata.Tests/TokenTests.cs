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
            var board = new Board();
            var token = new Token();

            board.PlaceToken(token);

            token.SquareNo.Should().Be(1);
        }
    }

    public class Board
    {
        public void PlaceToken(Token token)
        {
            token.SquareNo =1;
        }
    }

    public class Token
    {
        public int SquareNo { get; set; }
    }
}