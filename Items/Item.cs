using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runecape.Items
{
    internal class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        protected string type { get; set; }
        protected string tier { get; set; }
        protected int lowAlchValue { get; set; }
        protected int highAlchValue { get; set; }
        protected int[] statBoost { get; set; }
        
        public Item()
        {
            this.id = -1;
            this.name = "Null";
            this.desc = "Null.";
            this.type = "Null";
            this.tier = "Null";
            this.lowAlchValue = 0;
            this.highAlchValue = 0;
            this.statBoost = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        }

        public Item(int id,
                    string name,
                    string desc,
                    string type,
                    string tier,
                    int lowAlchValue,
                    int highAlchValue,
                    int[] statBoost)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.type = type;
            this.tier = tier;
            this.statBoost = new int[] {
                statBoost[0], //0 health
                statBoost[1], //1 attack
                statBoost[2], //2 strength
                statBoost[3], //3 defence
                statBoost[4], //4 magic
                statBoost[5], //5 range
                statBoost[6]  //6 prayer};
            };
            this.lowAlchValue = 0;
            this.highAlchValue = 0;
        }
    }
}
