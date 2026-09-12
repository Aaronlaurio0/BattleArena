using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Angel : Warrior

    {
        public Angel(string name, int health, int attackPower, WarriorType warriorType) 
            : base("Angel", health, attackPower, WarriorType.Magery)
        {
        }

        public override void Attack(Warrior target)
        {
            throw new NotImplementedException();
        }
    }
}
