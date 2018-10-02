using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifts_Character_Generator
{
    public class Attribute
    {
        public enum ATTRIBUTES { IQ, ME, MA, PS, PP, PE, PB, Spd }
        public ATTRIBUTES Type;
        public uint Value;
        public string Description = "";
        public string BonusDescription = "";
        public string DisplayTxt = "";

        public Attribute()
        {

        }

        public Attribute(ATTRIBUTES type, uint value)
        {
            Type = type;
            Value = value;
            switch (type)
            {
                case ATTRIBUTES.IQ:
                    Description = "Intelligence Quotient (I.Q.): Indicates the intelligence of the character. The exact I.Q. is equal to the I.Q. attribute multiplied times ten. ";
                    Description += "Characters with an I.Q.of 17 or better will receive a one time bonus added to all the character's skill percentages.";
                    BonusDescription = "I.Q. add to all skills. One time bonus.";
                    DisplayTxt = "I.Q.";
                    break;
                case ATTRIBUTES.ME:
                    Description = "Mental Endurance (M.E.): Measures the amount of mental and emotional stress the character can withstand.";
                    BonusDescription = "M.E. save vs. psychic attack/insanity";
                    DisplayTxt = "M.E.";
                    break;
                case ATTRIBUTES.MA:
                    Description = "Mental Affinity (M.A.): Shows the character's personal charm and charisma. Natural leaders, with an M.A. of 17 or higher, have a bonus to invoke trust or intimidation in others.";
                    BonusDescription = "M.A. trust/intimidate";
                    DisplayTxt = "M.A.";
                    break;
                case ATTRIBUTES.PS:
                    Description = "Physical Strength (P.S.): This is the raw physical power of the character.";
                    BonusDescription = "P. S. Hand to Hand Combat: Damage";
                    DisplayTxt = "P.S.";
                    break;
                case ATTRIBUTES.PP:
                    Description = "Physical Prowess (P.P.): Shows the degree of dexterity and agility of the character. A P.P.of 17 or higher is rewarded with bonuses to dodge, parry and strike.";
                    BonusDescription = "P.P. parry , dodge and strike bonus";
                    DisplayTxt = "P.P.";
                    break;
                case ATTRIBUTES.PE:
                    Description = "Physical Endurance (P.E.): Demonstrates the character's stamina and durability. ";
                    Description += "The amount of physical punishment, and resistance to fatigue and disease, are determined by P.E. A character can carry the maximum weight load for the P.E. times 4 minutes. ";
                    Description += "Carrying the maximum weight while running or fighting can only be done for the P.E. times 2 minutes. ";
                    Description += "If a character lifts the maximum weight, then it can only be held for as many melee rounds (15 seconds each) as the character has points of P.E. ";
                    Description += "A character can run at maximum speed for one minute for each point of P.E. Characters with a P.E. of 17 or better receive bonuses to save vs.coma, death, toxins, and magic.";
                    BonusDescription = "P.E. save vs. coma/death | save vs. poison & Magic";
                    DisplayTxt = "P.E.";
                    break;
                case ATTRIBUTES.PB:
                    Description = "Physical Beauty (P.B.): Is an indication of the physical attractiveness of the character. A P.B. of 17 or better will be rewarded with a bonus to charm or impress.";
                    BonusDescription = "P.B. charm/impress";
                    DisplayTxt = "P.B.";
                    break;
                case ATTRIBUTES.Spd:
                    Description = "Speed (Spd): Specifically, this is the character's maximum running speed. The Spd. times 20 is the number of yards or meters that the character can run in one minute.";
                    BonusDescription = "Spd: No special bonuses other than the raw, natural ability to run.";
                    DisplayTxt = "Spd";
                    break;
            }
        }
    }

    public class Attributes
    {
        Attribute attrIQ;
        Attribute attrME;
        Attribute attrMA;
        Attribute attrPS;
        Attribute attrPP;
        Attribute attrPE;
        Attribute attrPB;
        Attribute attrSpd;

        public Attributes()
        {
            
        }

        public Attributes(uint valIQ, uint valME, uint valMA, uint valPS, uint valPP, uint valPE, uint valPB, uint valSpd)
        {

        }

        public uint OneTimeSkillBonus()
        {

            uint val = attrIQ.Value;
            uint retVal = 0;
            if (val > 16)
            {
                retVal = val - 14;
            }
            return retVal;
        }

        public uint SaveVSPsyAtkandInsanityBonus()
        {
            uint val = attrME.Value;
            uint retVal = 0;

            if (val > 16)
            {
                retVal = 1;
                while (val >= 18)
                {
                    val -= 2;
                    retVal += 1;
                }
            }

            return retVal;
        }

        public uint TrustIntimidateBonus()
        {
            uint val = attrME.Value;
            uint retVal = 0;

            if (val > 16)
            {
                if (val <= 24)
                {
                    uint temp = val - 8;
                    retVal = temp * 5;
                }
                if (val > 24 && val <= 27)
                {
                    retVal = 80;
                    uint temp = val - 24;
                    retVal += (temp * 4);
                }
                if (val > 27 && val <= 29)
                {
                    retVal = 92;
                    uint temp = val - 27;
                    retVal += (temp * 2);
                }
                if (val > 29)
                {
                    if (val > 31)
                        val = 31;
                    retVal = 96;
                    uint temp = val - 29;
                    retVal += (temp * 1);
                }
            }

            return retVal;
        }

        public uint HandToHandCombatBonus()
        {
            uint val = attrPS.Value;
            uint retVal = 0;
            return retVal;
        }

        public uint ParryDodgeStrikeBonus()
        {
            uint val = attrPP.Value;
            uint retVal = 0;
            return retVal;
        }

        public uint SaveVSComaDeathBonus()
        {
            uint val = attrPE.Value;
            uint retVal = 0;
            return retVal;
        }

        public uint SaveVSPoisonMagic()
        {
            uint val = attrPE.Value;
            uint retVal = 0;
            return retVal;
        }

        public uint CharmImpressBonus()
        {
            uint val = attrPB.Value;
            uint retVal = 0;
            return retVal;
        }

        public uint Speed()
        {
            uint val = attrSpd.Value;
            uint retVal = 0;
            return retVal;
        }
    }
}
