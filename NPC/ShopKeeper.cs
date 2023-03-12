using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runecape.NPC
{
    internal class ShopKeeper : NPC
    {
        public ShopKeeper()
        {

        }

        public ShopKeeper(int id,
                         string name,
                         string desc,
                         bool isSocial)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;

            this.menuOptions = new string[] {
                    name,
                    "Talk",
                    "Trade",
                    "Examine"
                };
        }
    }
}
