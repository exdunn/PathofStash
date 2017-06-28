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
        public string corrupted { get; set; }
        public string levelMin { get; set; }
        public string levelMax { get; set; }
        public string iLvlMin { get; set; }
        public string IlvlMax { get; set; }
        public string qualityMin { get; set; }
        public string qualityMax { get; set; }
        public string armorMin { get; set; }
        public string armorMax { get; set; }
        public string energyShieldMin { get; set; }
        public string energyShieldMax { get; set; }
        public string evasionMin { get; set; }
        public string evasionMax { get; set; }
        public List<QueryModifier> explicitMods { get; set;}

        public Query()
        {
            explicitMods = new List<QueryModifier>();
        }

        public bool Match(Item item)
        {
            bool isMatch = true;
            if(!string.IsNullOrEmpty(name) && !name.Equals(item.name, StringComparison.InvariantCultureIgnoreCase)) {
                isMatch = false ;
            }
            if (!string.IsNullOrEmpty(type) && !type.Equals(item.typeLine, StringComparison.InvariantCultureIgnoreCase)) {
                isMatch = false;
            }
            if (!string.IsNullOrEmpty(league) && !league.Equals(item.league, StringComparison.InvariantCultureIgnoreCase)) {
                isMatch = false;
            }
            // add level/tier here
            if (!string.IsNullOrEmpty(iLvlMin) && Convert.ToInt32(iLvlMin) > item.iLvl) {
                isMatch = false;
            }
            if (!string.IsNullOrEmpty(IlvlMax) && Convert.ToInt32(IlvlMax) < item.iLvl) {
                isMatch = false;
            }
            // add quality here
            // add armor here
            // add energy shield here
            // add evasion here
            return isMatch;
        }
    }
}
