using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace BowlingKata
{
    public class BowlingTests
    {

        [Theory]
        [InlineData(1)]
        public void Roll_Set_The_Number_Of_Pins_Knocked_Down(int pins)
        {
            Bowling bowling = new Bowling();
            int score = bowling.Roll(pins);
            Assert.Equal(score, pins);
        }

        [Theory]
        [InlineData(11)]
        public void Roll_Cant_Knock_Down_MoreThan_Ten(int pins)
        {
            Bowling bowling = new Bowling();
            int score = bowling.Roll(pins);
            int maxResult = 10;
            Assert.Equal(maxResult, score);
        }

        [Theory]
        [InlineData(2)]
        public void Roll_Can_Try_Up_To_Two_Times_Each_Square(int pins)
        {
            Bowling bowling = new Bowling();
            int score = bowling.Roll(pins);
            score += bowling.Roll(pins);
            score += bowling.Roll(pins);
            int tries = bowling.Tryies;
            Assert.Equal(2, tries);
        }
    }
}
