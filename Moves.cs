using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JourneyOfChampions
{
    internal class Moves
    {
        /*
        public void SpecialMove(Character target)
        {
            int damage = 0;
            switch (target.Name)
            {
                case Characters.Diego:
                    Console.WriteLine("Diego Uses brazilian spin kick");
                    target.LosingHealth(highKickPower * 2);
                    // damage = calculator.CalculateDamage(highKickPower * 2, stamina,
                    // target.BlockPower, target.DodgeChance); // att göra detta uppfyller nog kraven bättre i synnerhet till uppgiften
                    stamina -= 30;
                    break;

                case Characters.Donald:
                    Console.WriteLine("Atomic strike");
                    target.LosingHealth(highPunchPower * 2);
                    stamina -= 25;
                    damage = calculator.CalculateDamage(highKickPower * 2, stamina,
                    target.BlockPower, target.DodgeChance);
                    break;

                case Characters.Wanaporn:
                    Console.WriteLine("Wanaporn uses Muay Thai Fury!");
                    target.LosingHealth(lowKickPower * 3);

                    damage = calculator.CalculateDamage(highKickPower * 2, stamina,
                    target.BlockPower, target.DodgeChance);

                    stamina -= 20;
                    break;

                case Characters.Asa:
                    Console.WriteLine("Åsa uses FrostHeal");
                    target.LosingHealth(lowPunchPower * 2);

                    damage = calculator.CalculateDamage(highKickPower * 2, stamina,
                    target.BlockPower, target.DodgeChance);

                    Health += 10; // lite heal
                    stamina -= 10;
                    break;

                case Characters.Vladimir:
                    Console.WriteLine("Vladimir uses Bear Hug!");
                    target.LosingHealth(highPunchPower * 3);

                    damage = calculator.CalculateDamage(highKickPower * 2, stamina,
                  target.BlockPower, target.DodgeChance);

                    stamina -= 40;
                    break;

                case Characters.Haakon:
                    Console.WriteLine("Haakon uses Fjord Smash!");
                    target.LosingHealth(highKickPower * 2 + lowKickPower);

                    damage = calculator.CalculateDamage(highKickPower * 2, stamina,
                  target.BlockPower, target.DodgeChance);

                    stamina -= 30;
                    break;
            }

            if (stamina < 0) stamina = 0;
            if (stamina == 0) Console.Write("damn i cant make a move");
        }
        public virtual void HighKick(Character target)
        {
            int damage = highKickPower;
            target.LosingHealth(damage);
            Moves.MakingMove("High Kick");
            stamina -= 20;
        }

        public virtual void LowKick(Character target)
        {
            int damage = lowKickPower;
            target.LosingHealth(damage);
            Moves.MakingMove("High Kick");
            stamina -= 10;
        }

        public virtual void HighPunch(Character target)
        {
            int damage = highPunchPower;
            target.LosingHealth(damage);
            Moves.MakingMove("High Punch");
            stamina -= 15;
        }

        public virtual void LowPunch(Character target)
        {
            int damage = lowPunchPower;
            target.LosingHealth(lowPunchPower);
            Moves.MakingMove("Low Punch");
            stamina -= 5;
        }

        public virtual void Block()
        {

        }

        public virtual void Dodge()
        {

        }

        public virtual void Recover()
        {

        } */
    }
        
}
