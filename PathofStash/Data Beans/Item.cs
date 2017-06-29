using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathofStash.Data_Beans;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace PathofStash
{
    public class Item {
        public string seller { get; set; }
        public string id { get; set; }
        public string icon { get; set; }
        private string Name;
        public string league { get; set; }
        public string typeLine { get; set; }
        public bool identified { get; set; }
        public bool corrupted { get; set; }
        private string Note;
        public string price { get; set; }
        public string enchantMod { get; set; }
        [JsonProperty("ilvl")]
        public string iLvl { get; set; }
        public string evasion { get; set; }
        public string armor { get; set; }
        public string energyShield { get; set; }
        public string tier { get; set; }
        public string level { get; set; }
        public string quality { get; set; }
        public List<Property> requirements { get; set; }
        public List<Modifier> explicitMods { get; set; }
        public List<Modifier> implicitMods { get; set; }
        public List<Modifier> craftedMods { get; set; }
        [JsonProperty("properties")]
        public List<Property> properties { get; set;}

        public string name {
            get {
                return this.Name;
            }
            set {
                string newValue = Regex.Replace(value, @"<<.*>>", string.Empty);
                Name = newValue;
            }
        }

        public string note {
            get {
                return Note;
            }
            set {
                Match match = Regex.Match(value, @"~(b\/o|price)");
                if (match.Success) {
                    price = value;
                }
                Note = value;
            }
        }

        public Item()
        {
            requirements = new List<Property>();
            explicitMods = new List<Modifier>();
            implicitMods = new List<Modifier>();
            craftedMods = new List<Modifier>();
            properties = new List<Property>();
        }

        // search for Modifier with mod == input and return its value
        // return Double.NaN if not found
        public double GetMod(string input) {
            foreach (Modifier mod in explicitMods) {
                if (mod.mod.Equals(input, StringComparison.CurrentCultureIgnoreCase)) {
                    Console.WriteLine("item mod: " + mod.mod);
                    return mod.value;
                }
            }
            return Double.NaN;
        }

        public string ToString(int indentSize)
        {
            string str = new string(' ', 4 * indentSize) + "name: " + name;
            str += "\n" + new string(' ', 4 * indentSize) + "ilvl: " + iLvl.ToString();
            str += "\n" + new string(' ', 4 * indentSize) + "id: " + id;
            str += "\n" + new string(' ', 4 * indentSize) + "league: " + league;
            str += "\n" + new string(' ', 4 * indentSize) + "typeLine: " + typeLine;
            str += "\n" + new string(' ', 4 * indentSize) + "identified: " + identified;
            str += "\n" + new string(' ', 4 * indentSize) + "corrupted: " + corrupted;
            str += "\n" + new string(' ', 4 * indentSize) + "note: " + note;
            str += "\n" + new string(' ', 4 * indentSize) + "properties: {";
            foreach(Property prop in properties)
            {
                str += "\n" + prop.ToString(indentSize + 1);
            }
            str += "\n" + new string(' ', 4 * indentSize) + "Explicit Mods: {";
            foreach (Modifier mod in explicitMods)
            {
                str += "\n" + mod.ToString(indentSize + 1);
            }
            return str;
        }

       public void ParseProperties() {
            foreach (Property prop in properties) {
                if(prop.name.Equals("Armour", StringComparison.CurrentCultureIgnoreCase)) {
                    armor = Regex.Match(prop.values[0][0], @"\d+").Value;
                }
                else if (prop.name.Equals("Energy Shield", StringComparison.CurrentCultureIgnoreCase)) {
                    energyShield = Regex.Match(prop.values[0][0], @"\d+").Value;
                } 
                else if (prop.name.Equals("Evasion Rating", StringComparison.CurrentCultureIgnoreCase)) {
                    evasion = Regex.Match(prop.values[0][0], @"\d+").Value;
                } 
                else if (prop.name.Equals("Map Tier", StringComparison.CurrentCultureIgnoreCase)) {
                    tier = Regex.Match(prop.values[0][0], @"\d+").Value;
                } 
                else if (prop.name.Equals("Level", StringComparison.CurrentCultureIgnoreCase)) {
                    level = Regex.Match(prop.values[0][0], @"\d+").Value;
                } 
                else if (prop.name.Equals("Quality", StringComparison.CurrentCultureIgnoreCase)) {
                    quality = Regex.Match(prop.values[0][0],@"\d+").Value;
                }
            }
        }
    }
}
