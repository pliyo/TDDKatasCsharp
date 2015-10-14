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

        [Fact]
        [Theory]
        [InlineData(1)]
        public void Roll_Set_The_Number_Of_Pins_Knocked_Down(int pins)
        {
            Bowling bowling = new Bowling();
            int result = bowling.Roll(pins);
            Assert.Equal(result, pins);
        }
    }
}
