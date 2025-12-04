using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyOfChampions
{
   
    interface IBattleCalculator
    {
        // KRAV 7:
        // 1: Subtypspolymorfism/Gränssnitt
        // 2: Ett Interface för att definiera metoder för skada och hälsa.
        // 3: För att bygga en flexibel struktur för olika stridsberäkningar som kan implementeras av olika klasser.

        void CalculateDamage(Character player, Character enemy);
        void CalculateDamageBoss(Character player, Character boss);
        void LosingHealth(Character player, Character enemy);
        void StaminaChange(Character player, Character enemy);
        void AttackAgainstBlock();
        void AttackAgainstDodge();
    }
}

