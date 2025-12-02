using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyOfChampions
{
    internal class Battle
    {
        public void StartFight(Character player, Character enemy)
        {
            Console.WriteLine($"\nA new fight begins! {player.Name} vs {enemy.Name}!");

            while (player.IsAlive && enemy.IsAlive)
            {
                Console.WriteLine($"\nYour HP: {player.Health}  |  {enemy.Name}'s HP: {enemy.Health}");
                Console.WriteLine("Choose your move:");
                Console.WriteLine("1) High Kick");
                Console.WriteLine("2) Low Kick");
                Console.WriteLine("3) Special Move");
                Console.Write("Your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        player.HighKick(enemy);
                        break;
                    case "2":
                        player.LowKick(enemy);
                        break;
                    case "3":
                        player.SpecialMove(enemy);
                        break;
                    default:
                        Console.WriteLine("You hesitated and missed your turn...");
                        break;
                }


            }
        }

        public void ComputerMove(Character player, Character computer)
        {
            string move = computer.CalculateMove(player, computer);
        }
    }
}
