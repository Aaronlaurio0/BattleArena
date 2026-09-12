using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena
{

    internal class Progress

    {
        static void Main(string[] args)
        {
            var Den = new Warriors.Den("Den", 100, 30, 3);
            var Lhi = new Warriors.Lhi("Lhi", 500, 5, 10);



            Den.DisplayStatus();
            Lhi.DisplayStatus();

            while (Den.IsAlive && Lhi.IsAlive)
            {
                Console.WriteLine($"================================");
                Den.Attack(Lhi);
                Lhi.DisplayStatus();
                Console.WriteLine("---------------------------------");
                Thread.Sleep(2000);
                
            }

            Console.ReadKey();
        }
    }
}