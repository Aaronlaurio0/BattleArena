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
            Warrior Den = new Warriors.Warrior();
            Den.Name = "Den";
            Den.Health = 100;
            Den.AttackPower = 30;

            Warrior Lhi = new Warriors.Warrior();
            Lhi.Name = "Lhi";
            Lhi.Health = 500;
            Lhi.AttackPower = 5;

            Console.WriteLine($"{Den.Name} has " +
    $"{Den.Health} health and {Den.AttackPower} attack power.");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"{Lhi.Name} has " +
                $"{Lhi.Health} health and {Lhi.AttackPower} attack power.");
            Console.WriteLine("----------------------------------------------");
            Console.ReadLine();

        }

    }
}
