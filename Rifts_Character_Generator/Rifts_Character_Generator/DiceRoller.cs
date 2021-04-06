﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifts_Character_Generator
{
    class DiceRoller
    {
        public enum DIE
        {
            D4 = 4,
            D6 = 6,
            D8 = 8,
            D10 = 10,
            D12 = 12,
            D20 = 20,
            D100 = 100
        }

        public enum MODE
        {
            NORMAL,
            HIGHEST_ONLY,
            LOWEST_ONLY,
            DISCARD_HIGHEST,
            DISCARD_LOWEST
        }

        Random roller = new Random(System.DateTime.Now.Millisecond);
        
        public UInt32 RollDice(DIE dieType, UInt32 dieQty, MODE rollMode, bool rerollOnes)
        {
            UInt32 retval = 0;
            UInt32[] dieRollVals = new UInt32[dieQty];

            for(UInt32 i = 0; i < dieQty; i++)
            {

                dieRollVals[i] = RollDie(dieType);
                if((true == rerollOnes) && dieRollVals[i] == 1)
                {
                    while(dieRollVals[i] == 1)
                    {
                        dieRollVals[i] = RollDie(dieType);
                    }
                }
                Console.Write(dieRollVals[i].ToString() + " ");
                retval += dieRollVals[i];
            }
            //Console.WriteLine();

            if(rollMode == MODE.HIGHEST_ONLY)
            {
                retval = dieRollVals.Max();
            }
            if(rollMode == MODE.LOWEST_ONLY)
            {
                retval = dieRollVals.Min();
            }

            if(rollMode == MODE.DISCARD_HIGHEST && dieRollVals.Length > 1)
            {
                retval -= dieRollVals.Max();
            }
            if (rollMode == MODE.DISCARD_LOWEST && dieRollVals.Length > 1)
            {
                retval -= dieRollVals.Min();
            }

            return retval;
        }

        UInt32 RollDie(DIE dieType)
        {
            UInt32 retval = 0;
            //Random rnd = new Random(system);
            switch(dieType)
            {
                case DIE.D4:
                    retval = (UInt32)roller.Next(1, 1 + (int)DIE.D4);
                    break;
                case DIE.D6:
                    retval = (UInt32)roller.Next(1, 1 + (int)DIE.D6);
                    break;
                case DIE.D8:
                    retval = (UInt32)roller.Next(1, 1 + (int)DIE.D8);
                    break;
                case DIE.D10:
                    retval = (UInt32)roller.Next(1, 1 + (int)DIE.D10);
                    break;
                case DIE.D12:
                    retval = (UInt32)roller.Next(1, 1 + (int)DIE.D12);
                    break;
                case DIE.D20:
                    retval = (UInt32)roller.Next(1, 1 + (int)DIE.D20);
                    break;
                case DIE.D100:
                    retval = (UInt32)roller.Next(1, 1 + (int)DIE.D100);
                    break;
            }
            return retval;
        }
    }
}
