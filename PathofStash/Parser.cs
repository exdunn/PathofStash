using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PathofStash
{
    class Parser
    {
        public List<Stash> stashes { get; set; }

        public Parser(string json)
        {
            stashes = new List<Stash>();
            Match match = Regex.Match(json, @"((\d+)-){4}\d+");

            Console.Write("Response Length: " + json.Length);
            if (json.Length > 0)
            {
                Console.WriteLine(json.Substring(0, 50));
            }

            Tokenize(json);
        }

        private void Tokenize(string json)
        {
            string cleanJson = Regex.Replace(json, @"{""next_change_id"":""((\d+)-){4}\d+"",""stashes"":\[", "[");
            cleanJson = Regex.Replace(cleanJson, @"]}$", "]");
            cleanJson = Regex.Replace(cleanJson, @","""",", ",");
            //File.WriteAllText("cleanJson.txt", cleanJson, Encoding.UTF8);
            var settings = new JsonSerializerSettings {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            stashes = JsonConvert.DeserializeObject<List<Stash>>(cleanJson, settings);
        }
    }
}
