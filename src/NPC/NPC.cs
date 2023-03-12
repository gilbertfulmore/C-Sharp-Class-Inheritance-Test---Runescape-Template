using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runecape.NPC
{
    internal class NPC
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        protected string[] menuOptions { get; set; }
        public int[] skills { get; set; }

        public NPC()
        {
            this.id = 0;
            this.name = "";
            this.desc = "";
            this.menuOptions = new string[] { 
                "Option 1", 
                "Option 2", 
                "Option 3" 
            };
            this.skills = new int[] { 0 } ;
        }
        
    }
}
