using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rifts_Character_Generator
{
    public partial class btnRollCharStats : Form
    {
        DiceRoller dieRoller;
        Attribute testAttribute;
        UInt32 val;
        Character myChar;
        public btnRollCharStats()
        {
            InitializeComponent();
            dieRoller = new DiceRoller();
            myChar = new Character();
            //testAttribute = new Attribute();
            //testAttribute.Type = Attribute.ATTRIBUTES.ME;
            //testAttribute.ValueBonus(30);
        }

        public void RollCharacterStats(ref Character myCharacter)
        {
            myCharacter.CharacterAttributes = new Attributes();
            val = dieRoller.RollDice(DiceRoller.DIE.D6, 4, DiceRoller.MODE.DISCARD_LOWEST, true);
            string exceptional = " (EXCEPTIONAL!)";
            if (val >= 16)
            {
                val += dieRoller.RollDice(DiceRoller.DIE.D6, 1, DiceRoller.MODE.NORMAL, true);
                exceptional = " (EXCEPTIONAL!)";
            }
            else
            {
                exceptional = "";
            }
            myCharacter.CharacterAttributes.SetIQ(val);
            numericUpDown_IQ.Value = (decimal)val;

            Console.WriteLine("I.Q. " + val.ToString() + exceptional);

            val = dieRoller.RollDice(DiceRoller.DIE.D6, 4, DiceRoller.MODE.DISCARD_LOWEST, true);
            if (val >= 16)
            {
                val += dieRoller.RollDice(DiceRoller.DIE.D6, 1, DiceRoller.MODE.NORMAL, true);
                exceptional = " (EXCEPTIONAL!)";
            }
            else
            {
                exceptional = "";
            }
            myCharacter.CharacterAttributes.SetME(val);
            numericUpDown_ME.Value = (decimal)val;

            Console.WriteLine("M.E. " + val.ToString() + exceptional);

            val = dieRoller.RollDice(DiceRoller.DIE.D6, 4, DiceRoller.MODE.DISCARD_LOWEST, true);
            if (val >= 16)
            {
                val += dieRoller.RollDice(DiceRoller.DIE.D6, 1, DiceRoller.MODE.NORMAL, true);
                exceptional = " (EXCEPTIONAL!)";
            }
            else
            {
                exceptional = "";
            }
            myCharacter.CharacterAttributes.SetMA(val);
            numericUpDown_MA.Value = (decimal)val;

            Console.WriteLine("M.A. " + val.ToString() + exceptional);

            val = dieRoller.RollDice(DiceRoller.DIE.D6, 4, DiceRoller.MODE.DISCARD_LOWEST, true);
            if (val >= 16)
            {
                val += dieRoller.RollDice(DiceRoller.DIE.D6, 1, DiceRoller.MODE.NORMAL, true);
                exceptional = " (EXCEPTIONAL!)";
            }
            else
            {
                exceptional = "";
            }
            myCharacter.CharacterAttributes.SetPS(val);
            numericUpDown_PS.Value = (decimal)val;

            Console.WriteLine("P.S. " + val.ToString() + exceptional);

            val = dieRoller.RollDice(DiceRoller.DIE.D6, 4, DiceRoller.MODE.DISCARD_LOWEST, true);
            if (val >= 16)
            {
                val += dieRoller.RollDice(DiceRoller.DIE.D6, 1, DiceRoller.MODE.NORMAL, true);
                exceptional = " (EXCEPTIONAL!)";
            }
            else
            {
                exceptional = "";
            }
            myCharacter.CharacterAttributes.SetPP(val);
            numericUpDown_PP.Value = (decimal)val;

            Console.WriteLine("P.P. " + val.ToString() + exceptional);

            val = dieRoller.RollDice(DiceRoller.DIE.D6, 4, DiceRoller.MODE.DISCARD_LOWEST, true);
            if (val >= 16)
            {
                val += dieRoller.RollDice(DiceRoller.DIE.D6, 1, DiceRoller.MODE.NORMAL, true);
                exceptional = " (EXCEPTIONAL!)";
            }
            else
            {
                exceptional = "";
            }
            myCharacter.CharacterAttributes.SetPE(val);
            numericUpDown_PE.Value = (decimal)val;

            Console.WriteLine("P.E. " + val.ToString() + exceptional);

            val = dieRoller.RollDice(DiceRoller.DIE.D6, 4, DiceRoller.MODE.DISCARD_LOWEST, true);
            if (val >= 16)
            {
                val += dieRoller.RollDice(DiceRoller.DIE.D6, 1, DiceRoller.MODE.NORMAL, true);
                exceptional = " (EXCEPTIONAL!)";
            }
            else
            {
                exceptional = "";
            }
            myCharacter.CharacterAttributes.SetPB(val);
            numericUpDown_PB.Value = (decimal)val;

            Console.WriteLine("P.B. " + val.ToString() + exceptional);

            val = dieRoller.RollDice(DiceRoller.DIE.D6, 4, DiceRoller.MODE.DISCARD_LOWEST, true);
            if (val >= 16)
            {
                val += dieRoller.RollDice(DiceRoller.DIE.D6, 1, DiceRoller.MODE.NORMAL, true);
                exceptional = " (EXCEPTIONAL!)";
            }
            else
            {
                exceptional = "";
            }
            myCharacter.CharacterAttributes.SetSpd(val);
            numericUpDown_Spd.Value = (decimal)val;

            Console.WriteLine("Spd " + val.ToString() + ", " + (val * 20).ToString() + " Meters/Min" + exceptional);
        }

        private void button_RollCharacterStats_Click(object sender, EventArgs e)
        {
            //try { Console.Clear(); } catch { };
            RollCharacterStats(ref myChar);
        }
    }
}
