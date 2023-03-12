using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runecape.Items
{
    internal class Food : Item
    {
        public int healAmount { get; set; }

        public Food()
        {
            this.healAmount = 0;
            this.id = 0;
            this.name = "Blank Food";
            this.desc = "A Blank Food that Heals " + this.healAmount + ".";
            this.type = "Food";
            this.lowAlchValue = 0;
            this.highAlchValue = 0;
        }

        public Food(int id,
                    string name,
                    string desc,
                    int healAmount,
                    int lowAlchValue,
                    int highAlchValue)
        {
            this.healAmount = healAmount;
            this.id = id;
            this.name = name;
            this.desc = desc + " that Heals " + this.healAmount + ".";
            this.type = "Food";
            this.lowAlchValue = lowAlchValue;
            this.highAlchValue = highAlchValue;
        }

        private int eatFood(int playerHealth)
        {
            return playerHealth += this.healAmount;
        }
    }
}
