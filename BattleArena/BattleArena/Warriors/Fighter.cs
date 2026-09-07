using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Fighter : Warrior
    {
        public Fighter(string name, int health, int attackPower, string specialAttackName) 
            : base(name, health, attackPower, specialAttackName)
        {

        }


    }
}
