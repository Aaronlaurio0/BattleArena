using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public enum WarriorType
    {
        Fighter,
        Marksman,
        Tank,
        Magery,
    }

    public abstract class Warrior
    {
        private bool _isAlive;
        private DamageInfo _damageTaken;
        public Random _random;
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }
        public WarriorType WarriorType { get; private set; }
        public bool IsAlive
        {
            get
            {
                _isAlive = Health > 0;
                return _isAlive;
            }
            private set { _isAlive = value;}
        }


        private bool _hasCriticalChance;

        public bool HasCriticalChance
        {
            get {
                var chance = _random.Next(0, 100);
                _hasCriticalChance = chance < 30;

                return _hasCriticalChance;
            }
         private set { _hasCriticalChance = value; }
        }


        public Warrior(string name, int health, int attackPower, WarriorType warriorType)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            WarriorType = warriorType;
        }

        protected virtual void TakeDamage(DamageInfo damage)
        {
            _damageTaken = damage;
            int actualDamage = damage.TotalAmountDamage;
            if (damage.IsCritical)
                actualDamage = damage.TotalAmountDamage * 2;
         
            Health -= actualDamage;
            if (Health < 0) Health = 0;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"------------=={Name}==-------------");
            if (_damageTaken.IsCritical)

                Console.WriteLine($"-----------Critical Hit------------");
            Console.WriteLine($"\t[+] Health: {Health}");
            Console.WriteLine($"\t[+] Attack Power: {AttackPower}");
            Console.WriteLine($"\t[+] Damage Taken : {_damageTaken.TotalAmountDamage }");
        }

        public abstract void Attack(Warrior target);
    }
}
