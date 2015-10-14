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
            KnockedDown = pins;
            return KnockedDown;
        }
    }
}
