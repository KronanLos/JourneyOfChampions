using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyOfChampions
{
     class MovesUsed
    {
        public int HighKicksUsed { get; private set; }
        public int LowKicksUsed { get; private set; }
        public int HighPunchesUsed { get; private set; }   
        public int LowPunchesUsed { get; private set; }
        public int BlocksUsed { get; private set; }
        public int DodgesUsed { get; private set; }
        public int SpecialMovesUsed { get; private set; }
        public int RecoversUsed { get; private set; }   

        public void AddingMoves() 
        {
            HighKicksUsed = 5;
            HighPunchesUsed = 3;
            LowKicksUsed = 4;
            LowPunchesUsed = 2;
            BlocksUsed = 4;
            DodgesUsed = 1;
            SpecialMovesUsed = 0;
        }
        public void MakingMove(string move)
        {
            switch (move)
            {
                case "High Kick":
                    HighKicksUsed++;
                    break;

                case "Low Kick":
                    LowKicksUsed++;
                    break;

                case "High Punch":
                    HighPunchesUsed++;
                    break;

                case "Low Punch":
                    LowPunchesUsed++;
                    break;

                case "Block":
                    BlocksUsed++;
                    break;

                case "Dodge":
                    DodgesUsed++;
                    break;

                case "Recover":
                    RecoversUsed++;
                    break;

                case "Special Move":
                    SpecialMovesUsed++;
                    break;

                default:
                    Console.WriteLine("Invalid move.");
                    break;


            }
        }
    }
}
