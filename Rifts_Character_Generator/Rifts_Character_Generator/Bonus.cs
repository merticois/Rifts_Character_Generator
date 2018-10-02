using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifts_Character_Generator
{
    public class Bonus
    {
        public enum BONUS_TYPE
        {
            ATTRIBUTE,
            STAT,
            COMBAT,
            SAVE,
            SKILL
        }
        public BONUS_TYPE bonusType;
        public int bonusVal;
        public Skill bonusSkill;

        public Bonus(BONUS_TYPE bonusType, int BonusValue, Skill bonuSkill)
        {

        }
    }
}
