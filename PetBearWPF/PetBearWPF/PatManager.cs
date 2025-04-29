using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBearWPF
{
    // This is where I'll keep track of how many "pats" the player has, and where upgrades will be tracked as well.
    class PatManager
    {
        public int TotalPats;
        public List<Upgrade> Upgrades = new();

        public void Pat()
        {
            TotalPats++;
        }

        public void AddUpgrade (Upgrade upgrade)
        {
            Upgrades.Add(upgrade);
        }

        public void ApplyPassivePats()
        {
            foreach (var up in Upgrades)
            {
                TotalPats += up.GetPatRate();
            }
        }

        public bool SpendPats(int amount)
        {
            if (TotalPats >= amount)
            {
                TotalPats -= amount;
                return true;
            }
            return false;
        }
    }
}
