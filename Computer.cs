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

        public string MostUsedMove { get; private set; }
        public string LeastUsedMove { get; private set; }
        public string StyleOfPlay { get; private set; }

        public Computer(string name) : base(name)
        {

        }   

        public override string CalculateMove(Character champion, Character computer, bool firstBattle) 
        {
            if (firstBattle)
            {
                StyleOfPlay = "Balanced";
                MostUsedMove = "High Kick";
                LeastUsedMove = "Low kick";
            }

            else 
            {
                moveChoices = new List<int> { };
                UserMoves(moveChoices, champion);
            }

            string move = BasicMoves();

            /*
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
            }*/
            return move;
        }

        private void UserMoves(List<int> moves, Character champion)
        {

            int highKick = champion.Moves.HighKicksUsed;
            int lowKick = champion.Moves.LowKicksUsed;
            int highPunch = champion.Moves.HighPunchesUsed;
            int lowPunch = champion.Moves.LowPunchesUsed;
            int block = champion.Moves.BlocksUsed;
            int dodge = champion.Moves.DodgesUsed;
            int recover = champion.Moves.RecoversUsed;

            int attackingMoves = highKick + lowKick + highPunch + lowPunch;
            int defensiveMoves = block + dodge + recover;

            if (attackingMoves > defensiveMoves)
            {
                StyleOfPlay = "Aggressive";
            }
            else if (defensiveMoves > attackingMoves)
            {
                StyleOfPlay = "Defensive";
            }
            else
            {
                StyleOfPlay = "Balanced";
            }


            Dictionary<string, int> moveDict = new Dictionary<string, int>
            {
                { "High Kick", highKick },
                { "Low Kick", lowKick },
                { "High Punch", highPunch },
                { "Low Punch", lowPunch },
                { "Block", block },
                { "Dodge", dodge },
                { "Recover", recover }
            };

            MostUsedMove = moveDict.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            LeastUsedMove = moveDict.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;

        }
        private string BasicMoves()
        {
            if (StyleOfPlay == "Aggressive")
            {
                List<string> aggressiveMoves = new List<string> { "High Kick", "Low Kick", "High Punch", "Low Punch" };
                int index = rnd.Next(aggressiveMoves.Count);
                return aggressiveMoves[index];
            }
            else if (StyleOfPlay == "Defensive")
            {
                List<string> defensiveMoves = new List<string> { "Block", "Dodge", "Recover" };
                int index = rnd.Next(defensiveMoves.Count);
                return defensiveMoves[index];
            }
            else // Balanced
            {
                List<string> allMoves = new List<string> { "High Kick", "Low Kick", "High Punch", "Low Punch", "Block", "Dodge", "Recover" };
                int index = rnd.Next(allMoves.Count);
                return allMoves[index];
            }
        }
        private void DiegoMoves(Character champion, List<int> moveChoices)
        {
            

        }
    }
}
