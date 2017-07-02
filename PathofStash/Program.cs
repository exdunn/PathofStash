using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathofStash
{
    static class Globals
    {
        public static string CURINDEXURL = "http://poe-rates.com/actions/getLastChangeId.php";
        public static string STASHAPIURL = "http://www.pathofexile.com/api/public-stash-tabs";
        public static string POETRADEURL = "http://poe.trade";
        public static String[] LEAGUES = { "2 Week Mayhem (JRE092)", "Legacy", "Standard", "2 Week Mayhem HC (JRE091)", "Hardcore Legacy", "Hardcore" };
        public static bool TESTMODE = true;
        public static string[] SOCKICONS = {
            "http://poe.trade/static/sockets/dex.png",
            "http://poe.trade/static/sockets/int.png",
            "http://poe.trade/static/sockets/str.png",
            "http://poe.trade/static/sockets/gen.png" };
        public static string[] LINKICONS = {
            "http://poe.trade/static/sockets/Socket_Link_Horizontal.png",
            "http://poe.trade/static/sockets/Socket_Link_Vertical.png" };
    }

    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            /*Utilities.SerializeHtmlNodes("../../Resources/mods.txt",
                @"//li[@class=""active-result group-option""]",
                "../../Resources/mods.json", Utilities.GetMods);*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
