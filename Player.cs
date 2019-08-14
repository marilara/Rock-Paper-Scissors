using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13Breakout_RPS
{
    abstract class Player
    {
        public string Name { get; set; }
        
        public Player(string Name)
        {
            this.Name = Name;
        }

        public abstract string GetRPS();
    }
}
