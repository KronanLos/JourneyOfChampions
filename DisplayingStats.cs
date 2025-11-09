using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JourneyOfChampions
{
    internal class DisplayingStats
    {

        public void DisplayStatsDiego()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Displaying stats for Diego:");
            Console.Write($"Character: Diego -- ");
            Console.Write($"Origin: Brazil -- ");
            Console.Write($"Health: 150 -- ");
            Console.WriteLine($"Stamina: 20");
            Console.Write($"High Kick Power: 15 -- ");
            Console.Write($"Low Kick Power: 10 -- ");
            Console.Write($"High Punch Power: 10 -- ");
            Console.Write($"Low Punch Power: 5 -- ");
            Console.WriteLine($"Block Power: 10");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
