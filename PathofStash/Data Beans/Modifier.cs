using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PathofStash.Data_Beans
{
    public class Modifier {

        public string mod { get; set; }
        public double value { get; set; }

        public Modifier(string input) {
            value = 0;
            ParseString(input);
        }

        public static implicit operator Modifier(string input) {
            return new Modifier(input);
        }

        public string ToString(int indentSize) {
            return new string(' ', 4 * indentSize) 
                + Regex.Replace(mod, @"#", value.ToString());
        }

        public override string ToString() {
            return @"""" + mod + @""": " + value.ToString();
        }

        private void ParseString(string input) {

            // extract all the integer values from the input
            string pattern = @"\d+\.*\d*";
            Regex reg = new Regex(pattern);
            MatchCollection mc = reg.Matches(input);

            // set value to the average of ints in input
            foreach (Match match in mc) {
                value += Double.Parse(match.Value);
            }
            value /= mc.Count;

            //replace ints in input with #
            mod = Regex.Replace(input, pattern, "#");
        }
    }
}
