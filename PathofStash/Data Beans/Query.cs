using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathofStash.Data_Beans
{
    struct QueryModifier
    {
        public string mod { get; set; }
        [DefaultValue(null)]
        public double? min { get; set; }
        [DefaultValue(null)]
        public double? max { get; set; }

        public void Print() {

            Console.WriteLine(mod + ": " + min + "-" + max);
        }
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
        public string ilvlMax { get; set; }
        public string qualityMin { get; set; }
        public string qualityMax { get; set; }
        public string armorMin { get; set; }
        public string armorMax { get; set; }
        public string energyShieldMin { get; set; }
        public string energyShieldMax { get; set; }
        public string evasionMin { get; set; }
        public string evasionMax { get; set; }
        public string socketsMin { get; set; }
        public string socketsMax { get; set; }
        public string linksMin { get; set; }
        public string linksMax { get; set; }
        public List<QueryModifier> explicitMods { get; set;}

        public Query()
        {
            explicitMods = new List<QueryModifier>();
        }

        public void AddExplicitMod(QueryModifier mod) {
            explicitMods.Add(mod);
        }

        public bool Match(Item item)
        {
            foreach (QueryModifier mod in explicitMods) {
                double value = item.GetMod(mod.mod);
                if (Double.IsNaN(value)) {
                    return false;
                } else {
                    if (mod.min > value || mod.max < value) {
                        return false;
                    }
                }
            }
            if (!string.IsNullOrEmpty(name) 
                && !name.Equals(item.name, StringComparison.InvariantCultureIgnoreCase)) {
                return false;
            }
            if (!string.IsNullOrEmpty(type) 
                && !type.Equals(item.typeLine, StringComparison.InvariantCultureIgnoreCase)) {
                return false;
            }
            if (!string.IsNullOrEmpty(league) 
                && !league.Equals(item.league, StringComparison.InvariantCultureIgnoreCase)) {
                return false;
            }
            if (!string.IsNullOrEmpty(levelMin)) {
                if (string.IsNullOrEmpty(item.level)
                    || Convert.ToInt32(levelMin) > Convert.ToInt32(item.level)) {
                    return false;
                }
            }
            if ((!string.IsNullOrEmpty(levelMax) && !string.IsNullOrEmpty(item.level)) 
                && Convert.ToInt32(levelMax) < Convert.ToInt32(item.level)) {
                return false;
            }
            if (!string.IsNullOrEmpty(iLvlMin)) {
                if (string.IsNullOrEmpty(item.iLvl)
                    || Convert.ToInt32(iLvlMin) > Convert.ToInt32(item.iLvl)) {
                    return false;
                }
            }
            if ((!string.IsNullOrEmpty(ilvlMax) && !string.IsNullOrEmpty(item.iLvl))
                && Convert.ToInt32(ilvlMax) < Convert.ToInt32(item.iLvl)) {
                return false;
            }
            if (!string.IsNullOrEmpty(qualityMin)) {
                if (string.IsNullOrEmpty(item.quality)
                    || Convert.ToInt32(qualityMin) > Convert.ToInt32(item.quality)) {
                    return false;
                }
            }
            if ((!string.IsNullOrEmpty(qualityMax) && !string.IsNullOrEmpty(item.quality))
                && Convert.ToInt32(qualityMax) < Convert.ToInt32(item.quality)) {
                return false;
            }
            if (!string.IsNullOrEmpty(armorMin)) {
                if (string.IsNullOrEmpty(item.armor)
                    || Convert.ToInt32(armorMin) > Convert.ToInt32(item.armor)) {
                    return false;
                }
            }
            if ((!string.IsNullOrEmpty(armorMax) && !string.IsNullOrEmpty(item.armor)) 
                && Convert.ToInt32(armorMax) < Convert.ToInt32(item.armor)) {
                return false;
            }
            if (!string.IsNullOrEmpty(energyShieldMin)) {
                if (string.IsNullOrEmpty(item.energyShield)
                    || Convert.ToInt32(energyShieldMin) > Convert.ToInt32(item.energyShield)) {
                    return false;
                }
            }
            if ((!string.IsNullOrEmpty(energyShieldMax) && !string.IsNullOrEmpty(item.energyShield))
                && Convert.ToInt32(energyShieldMax) < Convert.ToInt32(item.energyShield)) {
                return false;
            }
            if (!string.IsNullOrEmpty(evasionMin)) {
                if (string.IsNullOrEmpty(item.evasion)
                    || Convert.ToInt32(evasionMin) > Convert.ToInt32(item.evasion)) {
                    return false;
                }
            }
            if ((!string.IsNullOrEmpty(evasionMax) && !string.IsNullOrEmpty(item.evasion))
                && Convert.ToInt32(evasionMax) < Convert.ToInt32(item.evasion)) {
                return false;
            }
            if (!string.IsNullOrEmpty(socketsMin)) {
                if (Convert.ToInt32(socketsMin) > item.sockets.Count) {
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(socketsMax)) {
                if (Convert.ToInt32(socketsMax) < item.sockets.Count) {
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(linksMin)) {
                if (Convert.ToInt32(linksMin) > item.LongestLinkCount()) {
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(linksMax)) {
                if (Convert.ToInt32(linksMax) < item.LongestLinkCount()) {
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(corrupted) 
                && ((corrupted.Equals("Corrupted") && !item.corrupted)
                || (corrupted.Equals("Uncorrupted") && item.corrupted))) {
                return false;
            }
            return true;
        }

        public void Print() 
        {
            if (!string.IsNullOrEmpty(name)) {
                Console.WriteLine("Name: " + name);
            }
            if (!string.IsNullOrEmpty(type)) {
                Console.WriteLine("type: " + type);
            }
            if (!string.IsNullOrEmpty(league)) {
                Console.WriteLine("league: " + league);
            }
            if (!string.IsNullOrEmpty(corrupted)) {
                Console.WriteLine("corrupted: " + corrupted);
            }
            if (!string.IsNullOrEmpty(iLvlMin)) {
                Console.WriteLine("iLvlMin: " + iLvlMin);
            }
            if (!string.IsNullOrEmpty(ilvlMax)) {
                Console.WriteLine("IlvlMax: " + ilvlMax);
            }
            if (!string.IsNullOrEmpty(levelMin)) {
                Console.WriteLine("levelMin: " + levelMin);
            }
            if (!string.IsNullOrEmpty(levelMax)) {
                Console.WriteLine("levelMax: " + levelMax);
            }
            if (!string.IsNullOrEmpty(qualityMin)) {
                Console.WriteLine("qualityMin: " + qualityMin);
            }
            if (!string.IsNullOrEmpty(qualityMax)) {
                Console.WriteLine("qualityMax: " + qualityMax);
            }
            if (!string.IsNullOrEmpty(armorMin)) {
                Console.WriteLine("armorMin: " + armorMin);
            }
            if (!string.IsNullOrEmpty(armorMax)) {
                Console.WriteLine("armorMax: " + armorMax);
            }
            if (!string.IsNullOrEmpty(energyShieldMin)) {
                Console.WriteLine("energyShieldMin: " + energyShieldMin);
            }
            if (!string.IsNullOrEmpty(energyShieldMax)) {
                Console.WriteLine("energyShieldMax: " + energyShieldMax);
            }
            if (!string.IsNullOrEmpty(evasionMin)) {
                Console.WriteLine("evasionMin: " + evasionMin);
            }
            if (!string.IsNullOrEmpty(evasionMax)) {
                Console.WriteLine("evasionMax: " + evasionMax);
            }
            if (!string.IsNullOrEmpty(socketsMin)) {
                Console.WriteLine("socketsMin: " + socketsMin);
            }
            if (!string.IsNullOrEmpty(socketsMax)) {
                Console.WriteLine("socketsMax: " + socketsMax);
            }
            if (!string.IsNullOrEmpty(linksMin)) {
                Console.WriteLine("linksMin: " + linksMin);
            }
            if (!string.IsNullOrEmpty(linksMax)) {
                Console.WriteLine("linksMax: " + linksMax);
            }
            foreach (QueryModifier mod in explicitMods) {
                mod.Print();
            }
            Console.WriteLine("***************************************************");
        }
    }
}
