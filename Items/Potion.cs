using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runecape.Items
{
    internal class Potion : Item
    {
        public Potion()
        {
            this.id   = 0;
            this.name = "Blank Potion";
            this.desc = "A Blank Potion";
            this.type = "Potion";
            this.statBoost = new int[] 
            {
                0, //0 health
                0, //1 attack
                0, //2 strength
                0, //3 defence
                0, //4 magic
                0, //5 range
                0  //6 prayer
            };
        }

        public Potion(int id,
                      string name,
                      string desc,
                      int[] statBoost)
        {
            this.id   = id;
            this.name = name;
            this.desc = desc + ".";
            this.type = "Potion";
            this.statBoost = new int[] {
                statBoost[0], //0 health
                statBoost[1], //1 attack
                statBoost[2], //2 strength
                statBoost[3], //3 defence
                statBoost[4], //4 magic
                statBoost[5], //5 range
                statBoost[6]  //6 prayer
            };
        }
    }
}
