using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathofStash.Data_Beans;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace PathofStash {
    class Sniper {
        public string nextIndex;
        public bool sniping { get; set; }
        public Query query { get; set; }
        public List<Item> matches { get; set; }
        public Form1 form { get; set; }

        public Sniper(Form1 form) {
            this.form = form;
            matches = new List<Item>();
        }

        public void StartSniping() {
            if (!sniping) {
                return;
            }
            string curIndex = String.IsNullOrEmpty(nextIndex) ? CurStashIndex() : nextIndex;
            string stashUrl = Globals.STASHAPIURL + "?id=" + curIndex;
            MyWebRequest req = new MyWebRequest(stashUrl, "GET");
            Parser parser = new Parser(req.GetResponse());
            nextIndex = parser.nextIndex;

            foreach (Stash stash in parser.stashes) {
                foreach (Item item in stash.items) {
                    if (query.Match(item)) {
                        Console.WriteLine("MATCH FOUND FOR: " + item.name);
                        form.AddMatch(item);
                    }
                }
            }

            Console.WriteLine("current index:" + curIndex);
            Console.WriteLine("next index: " + parser.nextIndex);

            if (curIndex != parser.nextIndex) {
                int ms = 500;
                Console.WriteLine("At top of stream, waiting " + ms + "ms...");
                Thread.Sleep(ms);
            }
            StartSniping();
        }

        public void TestSnipe() {
            Console.WriteLine("TEST SNIPE");
            MyWebRequest req = new MyWebRequest("http://www.pathofexile.com/api/public-stash-tabs", "GET");
            Parser parser = new Parser(req.GetResponse());
            nextIndex = parser.nextIndex;

            Console.WriteLine(query.name);
            foreach (Stash stash in parser.stashes) {
                foreach (Item item in stash.items) {
                    item.ParseProperties();
                    if (query.Match(item)) {
                        Console.WriteLine("MATCH FOUND FOR: " + item.name);
                        form.AddMatch(item);
                    }
                }
            }
        }

        // fetch current stash index from http://poe-rates.com/actions/getLastChangeId.php
        private string CurStashIndex() {
            MyWebRequest req = new MyWebRequest(Globals.CURINDEXURL, "GET");
            return Regex.Match(req.GetResponse(), @"((\d+)-){4}\d+").ToString();
        }
    }
}
