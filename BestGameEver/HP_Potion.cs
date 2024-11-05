using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGameEver
{
    internal class HP_Potion
    {
        public int HPPotionID { get; private set; }
        public string Name { get; private set; }
        public int Potency { get; private set; }
        public int Durability { get; private set; }
        public int PlayerID { get; private set; }

        public HP_Potion(int hpPotionID, string name, int potency, int durability, int playerID)
        {
            HPPotionID = hpPotionID;
            Name = name;
            Potency = potency;
            Durability = durability;
            PlayerID = playerID;
        }
        public HP_Potion()
        {

        }

      
    }
}
   


