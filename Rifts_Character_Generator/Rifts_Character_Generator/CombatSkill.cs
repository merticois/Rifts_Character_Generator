using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifts_Character_Generator
{
    class CombatSkill
    {
        enum COMBATSKILL_TYPE
        {
            OFFENSIVE,
            DEFENSIVE,
            DAMAGE
        }
        COMBATSKILL_TYPE Type;
        string Name;
        public DiceRoller.DIE dmgDie;
        public uint qtyDie;
        public uint Value;
    }
}
