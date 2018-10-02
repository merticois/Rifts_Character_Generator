using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifts_Character_Generator
{
    public class Skill
    {
        public string Name;
        public int BasePercent;
        public int PercentPerLevel;
        List<Bonus> Bonuses;

        public Skill()
        {
            Bonuses = new List<Bonus>();
        }

        public Skill(string name, int basePercent, int percentPerLevel)
        {
            Name = name;
            BasePercent = basePercent;
            PercentPerLevel = percentPerLevel;
            Bonuses = new List<Bonus>();
        }

        public void AddBonus(Bonus newBonus)
        {
            Bonuses.Add(newBonus);
        }
    }
}
