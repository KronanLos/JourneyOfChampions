using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JourneyOfChampions
{
    internal class Computer : Character
    {
        Random rnd = new Random();
        List<int> moveChoices;

        public Computer(string name) : base(name)
        {

        }   

        public override string CalculateMove(Character champion, Character computer) 
        {
            moveChoices = new List<int> { };
            moveChoices = UserMoves(moveChoices, champion);

            switch (computer.Name)
            {
                case "Diego":
                    DiegoMoves(champion, moveChoices); 
                    break;
                case "Donald":
                    // DonaldMoves(champion);
                    break;
                case "Wanaporn":
                    // Implement Wanaporn's specific move logic here
                    break;
                case "Asa":
                    break;
                case "Vladimir":
                    break;
                case "Haakon":
                    break;
                default:
                    break;
            }
            return "";
        }

        private List<int> UserMoves(List<int> moves, Character champion)
        {
            int highKick = champion.Moves.HighKicksUsed;
            int lowKick = champion.Moves.LowKicksUsed;
            int highPunch = champion.Moves.HighPunchesUsed;
            int lowPunch = champion.Moves.LowPunchesUsed;
            int block = champion.Moves.BlocksUsed;
            int dodge = champion.Moves.DodgesUsed;

            int totalMoves = highKick + lowKick + highPunch + lowPunch + block + dodge;
    
            int multi = 100 / totalMoves;

            moves.Add((highKick * multi));
            moves.Add((lowKick * multi));
            moves.Add((highPunch * multi));
            moves.Add((lowPunch * multi));
            moves.Add((block * multi));
            moves.Add((dodge * multi));

            return moves;
        }
        private void DiegoMoves(Character champion, List<int> moveChoices)
        {
            

        }
    }
}
