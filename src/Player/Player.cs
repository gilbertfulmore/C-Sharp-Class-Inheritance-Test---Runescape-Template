using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runecape.Players
{
    internal class Player
    {
        public int id { get; set; }
        public string name { get; set; }
        public int combatLevel { get; set; }
        public int[] skills { get; set; }

        public Player()
        {
            this.id = 0;
            this.name = "";
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
            this.combatLevel = 0;
            
        }

        public Player(int id, 
                      string name, 
                      int[] skills)
        {
            this.id = id;
            this.name = name;
            this.skills = skills;
            this.combatLevel = generateCombatLevel(skills);
        }

        public int generateCombatLevel(int[] skills)
        {
            int health   = skills[0];
            int attack   = skills[1];
            int strength = skills[2];
            int defence  = skills[3];
            int magic    = skills[4];
            int range    = skills[5];
            int prayer   = skills[6];

            double cmbLVL;
            int[] array = new int[]
            {
                (attack + strength),
                magic*2,
                range*2
            };
            int maxValue = array.Max();
            cmbLVL = ( ( (1.3) * maxValue ) + defence + health + ( (0.5)*prayer) ) / 4;

            return Convert.ToInt32(Math.Floor(cmbLVL));
        }
    }
}
