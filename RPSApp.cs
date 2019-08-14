using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13Breakout_RPS
{
    class RPSApp
    {
        int wins = 0;
        int losses = 0;

        public void PlayGame()
        {
            Random randy = new Random();
            Player Player2 = new RandomPlayer("DefaultPlayer", randy);
            Rocky r = new Rocky("Rocky");
            RandomPlayer rp = new RandomPlayer("Bob", randy);

            Console.WriteLine();
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            Player Player1 = new Human(input);
            Console.WriteLine();
            Console.Write($"{Player1.Name}, would you like to play against {r.Name} or {rp.Name}? (r/b): ");
            string choice = Console.ReadLine().ToLower();

            if (choice == "r")
            {
                Player2 = new Rocky("Rocky");
            }
            else if (choice == "b")
            {
                Player2 = new RandomPlayer("Bob", randy);
            }

            bool playAgain = true;
            while (playAgain)
            {
                string Player1Pick = Player1.GetRPS();
                string Player2Pick = Player2.GetRPS();

                Console.WriteLine();
                Console.WriteLine($"{Player1.Name}: {Player1Pick}");
                Console.WriteLine($"{Player2.Name}: {Player2Pick}");
                Console.WriteLine();
                Console.WriteLine(Player1Stats(Player1Pick, Player2Pick));

                Console.WriteLine();
                Console.WriteLine("Would you like to play again? (Y/N) ");
                string repeat = Console.ReadLine().ToLower();
                if (repeat == "n")
                {
                    break;
                }
                else if (repeat == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("I'm sorry I didn't follow that response. Let's try again.");
                    Console.WriteLine();
                    continue;
                }
            }
        }
        public string Player1Stats(string Player1Pick, string Player2Pick)
        {
            if (Player1Pick == RPSEnum.Rock.ToString())
            {
                if (Player2Pick == RPSEnum.Rock.ToString())
                {
                    return $"It's a tie! \nYour Wins: {wins} \tYour Losses: {losses}";
                }
                else if (Player2Pick == RPSEnum.Paper.ToString())
                {
                    losses += 1;
                    return $"You Lose! \nYour Wins: {wins} \tYour Losses: {losses}";
                }
                else if (Player2Pick == RPSEnum.Scissors.ToString())
                {
                    wins += 1;
                    return $"You Win! \nYour Wins: {wins} \tYour Losses: {losses}";
                }
            }
            else if (Player1Pick == RPSEnum.Paper.ToString())
            {
                if (Player2Pick == RPSEnum.Rock.ToString())
                {
                    wins += 1;
                    return $"You Win! \nYour Wins: {wins} \tYour Losses: {losses}";
                }
                else if (Player2Pick == RPSEnum.Paper.ToString())
                {
                    return $"It's a tie! \nYour Wins: {wins} \tYour Losses: {losses}";
                }
                else if (Player2Pick == RPSEnum.Scissors.ToString())
                {
                    losses += 1;
                    return $"You Lose! \nYour Wins: {wins} \tYour Losses: {losses}";
                }
            }
            else if (Player1Pick == RPSEnum.Scissors.ToString())
            {
                if (Player2Pick == RPSEnum.Rock.ToString())
                {
                    losses += 1;
                    return $"You Lose! \nYour Wins: {wins} \tYour Losses: {losses}";

                }
                else if (Player2Pick == RPSEnum.Paper.ToString())
                {
                    wins += 1;
                    return $"You Win! \nYour Wins: {wins} \tYour Losses: {losses}";

                }
                else if (Player2Pick == RPSEnum.Scissors.ToString())
                {
                    return $"It's a tie! \nYour Wins: {wins} \tYour Losses: {losses}";
                }
            }

            return "";
        }
    }
}
