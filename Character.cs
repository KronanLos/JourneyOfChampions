using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace JourneyOfChampions
{
    internal class Character
    {
        private string origin = "Sweden";
        private int health;
        private int stamina;
        private int highKickPower;
        private int lowKickPower;
        private int highPunchPower;
        private int lowPunchPower;
        private int blockPower;

        // private int speed;

        public Character(string name) 
        {
            switch (name)
            {
                case "Jorge":
                    SetDiegoStats();
                    break;
                default:
                    break;
            }

        }

        private Characters name;
        enum Characters
        {
            Diego,
            Donald,
            Wanaporn,
            Asa,
            Vladimir,
            Haakon

        }

        private void SetDiegoStats()
        {
            name = Characters.Diego;
            origin = "Brazil";
            health = 150;
            stamina = 100;
            highKickPower = 25;
            lowKickPower = 15;
            highPunchPower = 20;
            lowPunchPower = 10;
            blockPower = 30;
        }

    }
}
