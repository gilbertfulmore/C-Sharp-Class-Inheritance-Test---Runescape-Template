using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runecape.Items
{
    internal class Weapon : Item
    {
        public Weapon()
        {
            this.id = 0;
            this.name = "Blank Weapon";
            this.desc = "A Blank Weapon";
            this.type = "Weapon";
            this.statBoost = new int[] {
                0, //0 health
                0, //1 attack
                0, //2 strength
                0, //3 defence
                0, //4 magic
                0, //5 range
                0  //6 prayer
            };
        }

        public Weapon(int itemID, 
                      string itemName, 
                      string itemDesc, 
                      string itemType,
                      int[] statBoost)
        {
            this.id = id;
            this.name = name;
            this.desc = desc + ".";
            this.type = type;

            this.statBoost = new int[]
            {
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
