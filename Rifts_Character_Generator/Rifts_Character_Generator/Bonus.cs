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
        //public int bonusVal;
        //public Skill bonusSkill;

        //public Bonus(BONUS_TYPE bonusType)
        //{

        //}
    }

    public class AttributeBonus : Bonus
    {
        public Attribute.ATTRIBUTES AttributeType;
        public int bonusVal
        {
            get;
            set;
        }
        public AttributeBonus(Attribute.ATTRIBUTES type, int value)
        {
            this.bonusType = BONUS_TYPE.ATTRIBUTE;
            AttributeType = type;
            bonusVal = value;
        }
    }

    public class CombatBonus : Bonus
    {
        public Attribute.ATTRIBUTES AttributeType;
        public int bonusVal
        {
            get;
            set;
        }
        public CombatBonus(int value)
        {
            this.bonusType = BONUS_TYPE.ATTRIBUTE;
            //AttributeType = type;
            bonusVal = value;
        }
    }
}
