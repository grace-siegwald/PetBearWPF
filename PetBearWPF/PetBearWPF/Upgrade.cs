using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBearWPF
{
    // The base class for all upgrades.
    abstract class Upgrade
    {
        public string Name;
        public int Cost;

        public abstract int GetPatRate();
    }
}
