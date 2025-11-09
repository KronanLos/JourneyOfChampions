using System.Diagnostics;
using System.Threading.Tasks;
using NetCoreAudio;


namespace JourneyOfChampions
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Journey of Champions";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Magenta;

            var player = new Player();
            await player.Play(@"sounds\QuirkyRunner.mp3");



            Console.WriteLine("Your journey to be a champion starts now!");
            Console.WriteLine("Get ready...");
            Console.WriteLine("Your first decision is to choose which character you wanna use");
            Console.WriteLine("You have the following options: Jorge, Donald, Wanaporn, Asa, Vladimir, Haakon");
            Console.Write("Type the name of your character: ");
            string characterName = Console.ReadLine();







        }

        

    }
}
