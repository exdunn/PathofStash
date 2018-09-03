using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathofStash.Data_Beans;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Media;

namespace PathofStash {

    class Sniper {

        public string changeId;
        public bool sniping { get; set; }
        public Query query { get; set; }
        public List<Item> matches { get; set; }
        public Form1 form { get; set; }

        public Sniper(Form1 form) {
            this.form = form;
            matches = new List<Item>();
            changeId = getChangeId();
        }

        public void StartSniping() {
            if (!sniping) {
                return;
            }



            string curChangeId = getChangeId();
            while (changeId == curChangeId)
            {
                curChangeId = getChangeId();
            }
            changeId = curChangeId;

            string stashUrl = Globals.STASHAPIURL + "?id=" + changeId;
            MyWebRequest req = new MyWebRequest(stashUrl, "GET");
            Parser parser = new Parser(req.GetResponse());

            List<Item> matches = new List<Item>();
            foreach (Stash stash in parser.stashes) {
                stash.SetItemsSeller();
                foreach (Item item in stash.items) {         
                    item.ParseProperties();
                    if (query.Match(item)) {
                        SystemSounds.Hand.Play();
                        Console.WriteLine("MATCH: " + item.ToString(1));
                        matches.Add(item);
                    }
                }
            }

            form.UpdateMatchPanel(matches);
            Thread.Sleep(200);
            StartSniping();
        }

        public void TestSnipe() {
            Console.WriteLine("********************TEST SNIPE***************************");
            MyWebRequest req = new MyWebRequest("http://www.pathofexile.com/api/public-stash-tabs?id=71343349-75103688-70275586-81686737-75948888", "GET");
            Parser parser = new Parser(req.GetResponse());

            Console.WriteLine(query.name);
            foreach (Stash stash in parser.stashes) {
                stash.SetItemsSeller();
                foreach (Item item in stash.items) {
                    item.ParseProperties();
                    if (query.Match(item)) {
                        Console.WriteLine("MATCH: " + item.ToString(1));
                    }
                }
            }
        }

        // fetch current stash index from the link in CURINDEXURL
        private string getChangeId() {
            MyWebRequest req = new MyWebRequest(Globals.CURINDEXURL, "GET");
            return Regex.Match(req.GetResponse(), @"((\d+)-){4}\d+").ToString();
        }
    }
}
