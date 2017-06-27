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
        public string nextIndex;

        public Parser(string json)
        {
            stashes = new List<Stash>();
            Match match = Regex.Match(json, @"((\d+)-){4}\d+");
            if(match.Success)
            {
                nextIndex = match.ToString();
            }
            Tokenize(json);
        }

        private void Tokenize(string json)
        {
            string cleanJson = Regex.Replace(json, @"{""next_change_id"":""((\d+)-){4}\d+"",""stashes"":\[", "[");
            cleanJson = Regex.Replace(cleanJson, @"]}$", "]");
            //File.WriteAllText("cleanJson.txt", cleanJson, Encoding.UTF8);
            stashes = JsonConvert.DeserializeObject<List<Stash>>(cleanJson);
        }
    }
}
