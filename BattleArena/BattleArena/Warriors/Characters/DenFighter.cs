using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Den : Warrior
    {
        public int SwordDamage;
        public Den(string name, int health, int attackPower, int swordDamage)
            : base("Den", health, attackPower, WarriorType.Fighter)
        {
            SwordDamage = swordDamage;
            attackPower = SwordDamage;
        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower + SwordDamage;
            var dmgInfo = new DamageInfo(AttackPower, "sapak", HasCriticalChance);
            TakeDamage(dmgInfo);
            Console.WriteLine($"\t->{Name}: Para sayo ang laban na to{target.Name}!");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: Bopis! ");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: Hihihihihihi! ");
            Thread.Sleep(1000);

            Console.WriteLine($"\t------- {target.Name} ------");
            Console.WriteLine($"\t    * DamageTaken: {totalDamage}");
            Console.WriteLine($"\t    * Health Remaining: {target.Health}");
        }
    }
}