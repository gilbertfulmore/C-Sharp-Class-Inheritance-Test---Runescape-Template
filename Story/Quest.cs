using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runecape.Story
{
    internal class Quest
    {
        private int questID { get; set; }
        private string questName { get; set; }
        private string[] dialog { get; set; }

        public Quest(int questID, string questName, int dialogSize)
        {
            this.questID = questID;
            this.questName = questName;
            this.dialog = new string[dialogSize];
        }
    }
}
