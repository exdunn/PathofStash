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
    public class Item
    {
        public int ilvl { get; set; }
        public string id { get; set; }
        public string icon { get; set; }
        private string Name;
        public string name
        {
            get
            {
                return this.Name;
            }
            set
            {
                string newValue = Regex.Replace(value, @"<<.*>>", string.Empty);
                Name = newValue;
            }
        }
        public string league { get; set; }
        public string typeLine { get; set; }
        public bool identified { get; set; }
        public bool corrupted { get; set; }
        public string note { get; set; }
        public string enchantMod { get; set; }
        public List<Property> properties { get; set; }
        public List<Property> requirements { get; set; }
        public List<Modifier> explicitMods { get; set; }
        public List<Modifier> implicitMods { get; set; } 
        public List<Modifier> craftedMods { get; set; }

        public Item()
        {
            properties = new List<Property>();
            requirements = new List<Property>();
            explicitMods = new List<Modifier>();
            implicitMods = new List<Modifier>();
            craftedMods = new List<Modifier>();
        }

        public string ToString(int indentSize)
        {
            string str = new string(' ', 4 * indentSize) + "name: " + name;
            str += "\n" + new string(' ', 4 * indentSize) + "ilvl: " + ilvl.ToString();
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

        public void AddProperty(Property value)
        {
            properties.Add(value);
        }

        public void AddRequirement(Property value)
        {
            requirements.Add(value);
        }

        public void AddExplicitMod(Modifier value)
        {
            explicitMods.Add(value);
        }

        public void AddImplicitMod(Modifier value)
        {
            implicitMods.Add(value);
        }

        public void AddCraftedMods(Modifier value)
        {
            craftedMods.Add(value);
        }
    }
}
