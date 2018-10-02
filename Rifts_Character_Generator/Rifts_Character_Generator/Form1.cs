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
    public partial class Form1 : Form
    {
        DiceRoller dieRoller;
        Attribute testAttribute;
        UInt32 val; 
        public Form1()
        {
            InitializeComponent();
            dieRoller = new DiceRoller();

            val = dieRoller.RollDice(DiceRoller.DIE.D6, 10, DiceRoller.MODE.REROLL_ONES);
            //testAttribute = new Attribute();
            //testAttribute.Type = Attribute.ATTRIBUTES.ME;
            //testAttribute.ValueBonus(30);
        }
    }
}
