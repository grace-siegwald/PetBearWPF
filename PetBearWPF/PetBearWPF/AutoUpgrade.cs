using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBearWPF
{
    // Inherits from the Upgrade class. These are the upgrades that auto increase pat count.
    class AutoUpgrade : Upgrade
    {
        public int PetsPerSecond;
        public int Quantity = 0;

        public void Buy()
        {
            Quantity++;
        }
        public void Buy(int count)
        {
            Quantity += count;
        }


        
        public override int GetPatRate()
        {
            return PetsPerSecond * Quantity;
        }
    }
}
