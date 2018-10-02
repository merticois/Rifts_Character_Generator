using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifts_Character_Generator
{
    
    //string [] AttributeDescriptions
    public class Character
    {
        enum ALIGNMENT
        {
            PRINCIPLED,
            SCRUPULOUS,
            UNPRINCIPALED,
            ANARCHIST,
            MISCREANT,
            DIABOLIC,
            ABERRANT,
            MAX_ALIGNMENTS
        }
        String[] AlignmentDescriptions = new String[(int)ALIGNMENT.MAX_ALIGNMENTS];

        public String Name;
        public String Race;
        public String TrueName;
        ALIGNMENT Alignment;

        public Attributes CharacterAttributes;

        public Character()
        {
            //CharacterAttributes = new Attributes()
            //string
        }
    }
}
