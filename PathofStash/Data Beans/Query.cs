using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathofStash.Data_Beans
{
    struct QueryModifier
    {
        string mod { get; set; }
        int min { get; set; }
        int max { get; set; }
    }

    class Query
    {
        public string name { get; set; }
        public string type { get; set; }
        public string league { get; set; }
        public bool corrupted { get; set; }
        public int levelMin { get; set; }
        public int levelMax { get; set; }
        public int iLvlMin { get; set; }
        public int IlvlMax { get; set; }
        public int qualityMin { get; set; }
        public int qualityMax { get; set; }
        public int armorMin { get; set; }
        public int armorMax { get; set; }
        public int energyShieldMin { get; set; }
        public int energyShieldMax { get; set; }
        public int evasionMin { get; set; }
        public int evasionMax { get; set; }
        public List<QueryModifier> explicitMods { get; set;}

        public Query()
        {
            explicitMods = new List<QueryModifier>();
        }

        public bool Match(Item item)
        {
            if(name.Equals(item.name, StringComparison.InvariantCultureIgnoreCase)) {
                return true;
            }
            return false;
        }
    }
}
