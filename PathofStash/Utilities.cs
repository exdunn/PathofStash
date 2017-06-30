using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;

namespace PathofStash
{
    /// <summary>
    /// Json-serializeable class for PoE item mods
    /// </summary>
    public struct JsonMod
    {
        public string type { get; set;}
        public string mod { get; set; }
    }

    public static class Utilities
    {

        // loads html from url and selects the HtmlNodes at xPath and writes the results to outFile
        // func defines rules on how to parse the HtmlNodes
        public static void SerializeHtmlNodes(string url, string xPath, string outFile, Action<HtmlNode[], string> func)
        {
            var doc = new HtmlDocument();
            doc.Load(url);
            HtmlNode[] nodes = doc.DocumentNode.SelectNodes(xPath).ToArray();
            func(nodes, outFile);    
        }

        // returns tokens extracted by deserializing json at path
        public static T[] DeserializeJson<T>(string path) {
            StreamReader reader = new StreamReader(path);
            string json = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<T[]>(json);
        }

        // parse nodes for item mods and serialize as json
        public static void GetMods(HtmlNode[] nodes, string outFile)
        {
            List<JsonMod> tokens = new List<JsonMod>();

            foreach (HtmlNode item in nodes) {
                JsonMod mod = new JsonMod();
                Match match = Regex.Match(item.InnerHtml, @"(?i)implicit|crafted|enchant|(prophecy)|(leaguestone)");

                if (match.Success) {
                    mod.type = match.Value;
                }
                else {
                    mod.type = "explicit";
                }

                // clean up item by removing boiler plate tags and leagin spaces
                string cleanMod = Regex.Replace(item.InnerHtml, @"(?i)implicit|crafted|enchant|(prophecy)|(leaguestone)", "");
                cleanMod = Regex.Replace(cleanMod, @"(<span).*(span> )", "");
                cleanMod = Regex.Replace(cleanMod, @"^ |^\(\) ", "");
                mod.mod = cleanMod;
                tokens.Add(mod);
            }
            String json = JsonConvert.SerializeObject(tokens);
            File.WriteAllText(outFile, json, Encoding.UTF8);
        }
    }
}
