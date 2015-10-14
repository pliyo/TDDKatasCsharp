using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKata
{
    public class Bowling
    {
        public int Tryies;
        public int Score;


        public int Roll(int pins)
        {
            if(Tryies < 2)
            { 
                Tryies = Tryies + 1;
                if (pins > 10) pins = 10;
                Score = pins;
                return Score;
            }
            return 0;
        }
    }
}
