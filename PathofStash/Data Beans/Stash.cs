using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathofStash
{
    class Stash
    {
        public string accountName { get; set; }
        public string stash { get; set; }
        public string lastCharacterName { get; set; }
        public string id { get; set; }
        public string stashType { get; set; }
        [JsonProperty("public")]
        public bool pub { get; set; }
        [JsonProperty("items")]
        public List<Item> items { get; set; }

        public Stash()
        {
            items = new List<Item>();
        }

        public void PrintStash()
        {
            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine("Stash: " + stash);
            Console.WriteLine("Last Character Name: " + lastCharacterName);
            Console.WriteLine("id: " + id);
            Console.WriteLine("Stash Type: " + stashType);
            Console.WriteLine("Public: " + pub);
            Console.WriteLine("Items: {");
            foreach (Item item in items)
            {
                Console.WriteLine("\n" + item.ToString(1));
            }
            Console.WriteLine("}");
            Console.WriteLine("***************************************************************************************");
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public void SetItemsSeller() {
            foreach (Item item in items) {
                Console.WriteLine(lastCharacterName);
                item.seller = lastCharacterName;
            }
        }
    }
}
