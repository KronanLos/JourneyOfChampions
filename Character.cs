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
        private int highKickPower;  // high damage, high stamina cost
        private int lowKickPower;   // medium damage, medium stamina cost
        private int highPunchPower; // medium damage, medium stamina cost
        private int lowPunchPower;  // low damage, low stamina cost
        private int blockPower;     // reduces damage taken, low stamina gain
        private int dodgeChance;    // chance to completely avoid an attack, medium stamina gain
        private int recoveryRate;  // recovers stamina while doing nothing, high stamina gain, takes full damage


        // Character movements will affect stamina and health differently based on their power levels
        // Moves: High Kick, Low Kick, High Punch, Low Punch, Block, Dodge, Recover


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
