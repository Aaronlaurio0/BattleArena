using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{

    internal class Progress

    {
        static void Main(string[] args)
        {
            int round = 1;
            Warrior Den = new Warriors.Warrior("Den", 100, 30, "Death Mark");
            Warrior Lhi = new Warriors.Warrior("Lhi", 500, 5, "Shouting Wave");

            Den.DisplayStatus();
            Lhi.DisplayStatus();

            while (Den.IsAlive && Lhi.IsAlive)
            {
                Console.WriteLine($"--------Round  {round}----------");
                Den.Attack(Lhi);
                Lhi.Attack(Den);
                Console.WriteLine("---------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}