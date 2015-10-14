using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKata
{
    public class Bowling
    {
        public int KnockedDown;

        public int Roll(int pins)
        {
            if (pins > 10) pins = 10;
            KnockedDown = pins;
            return KnockedDown;
        }
    }
}
