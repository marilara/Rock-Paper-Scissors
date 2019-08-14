using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13Breakout_RPS
{
    class Rocky : Player
    {
        public Rocky(string Name) : base(Name)
        {
        }

        public override string GetRPS()
        {
            return RPSEnum.Rock.ToString();
        }
    }
}
