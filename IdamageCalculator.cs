using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyOfChampions
{
   
        interface IBattleCalculator
        {
            void CalculateDamage(Character player, Character enemy);
            void CalculateDamageBoss(Character player, Character boss);
            void LosingHealth(Character player, Character enemy);
            void StaminaChange(Character player, Character enemy);
            void AttackAgainstBlock();
            void AttackAgainstDodge();
    }
}

