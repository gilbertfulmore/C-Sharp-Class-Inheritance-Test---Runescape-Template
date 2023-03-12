using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runecape.NPC
{
    internal class Mob : NPC
    {
        public int combatLevel { get; set; }

        public Mob()
        {
            this.id = 0;
            this.name = "Blank Mob";
            this.desc = "A blank Mob!"; ;
            this.combatLevel = 3;
            this.skills = new int[]
            {
                10, //health
                1,  //attack
                1,  //strength
                1,  //defence
                1,  //magic
                1,  //range
                1   //prayer
            };
        }

        public Mob(int id,
                   string name,
                   string desc,
                   bool isSocial,
                   int combatLevel,
                   int[] skills)
        {
            this.id          = id;
            this.name        = name;
            this.desc        = desc;
            this.combatLevel = combatLevel;
            this.skills      = skills;

            if (isSocial)
            {
                this.menuOptions = new string[] {
                    name + " - (" + combatLevel + ")",
                    "Attack",
                    "Talk",
                    "Examine"
                };
            }
            else
            {
                this.menuOptions = new string[] {
                    name + " - (" + combatLevel + ")",
                    "Attack",
                    "Examine"
                };
            }
        }
    }
}
