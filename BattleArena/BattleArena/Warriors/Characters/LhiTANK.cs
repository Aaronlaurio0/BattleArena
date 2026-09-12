using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Lhi : Warrior
    {
        public int Shield;
        public Lhi(string name, int health, int attackPower, int shield)
            : base("Lhi", health, attackPower, WarriorType.Tank)
        {
            Shield = shield;
        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower - Shield;
            var dmgInfo = new DamageInfo(AttackPower, "Huuu", HasCriticalChance);
            TakeDamage(dmgInfo);
            Console.WriteLine($"\t->{Name}: Tara dito boi {target.Name}!");
            Thread.Sleep(1000);
            Console.WriteLine($"\t->{target.Name}: Ibaon mo! ");
            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}:Wowowiwow! ");
            Thread.Sleep(1000);
            Console.WriteLine($"\t------- {target.Name} ------");
            Console.WriteLine($"\t    * DamageTaken: {totalDamage}");
            Console.WriteLine($"\t    * Health Remaining: {target.Health}");
        }



        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.ActualAmountDamage - Shield;
            var newDmgInfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical);
            base.TakeDamage(newDmgInfo);
        }



    }
}
