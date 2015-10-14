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
            int result = bowling.Roll(pins);
            Assert.Equal(result, pins);
        }

        [Theory]
        [InlineData(11)]
        public void Rell_Cant_Knock_Down_MoreThan_Ten(int pins)
        {
            Bowling bowling = new Bowling();
            int result = bowling.Roll(pins);
            int maxResult = 10;
            Assert.Equal(maxResult, result);
        }
    }
}
