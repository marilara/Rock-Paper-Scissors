using System;

namespace Lab13Breakout_RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            RPSApp newGame = new RPSApp();
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            newGame.PlayGame();
        }
    }
}
