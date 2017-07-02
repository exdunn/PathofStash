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
        public List<Double> values;

        public Modifier(string input) {
            values = new List<Double>();
            ParseString(input);
        }

        public static implicit operator Modifier(string input) {
            return new Modifier(input);
        }

        public string ToString(int indentSize) {
            return new string(' ', 4 * indentSize)
                + Regex.Replace(mod, @"#", GetAverage().ToString());
        }

        public override string ToString() {
            string modWithValues = mod;
            Regex reg = new Regex(@"#");
            MatchCollection matches = reg.Matches(modWithValues);

            for (int i = 0; i < matches.Count; i++) {
                modWithValues = reg.Replace(modWithValues, values[i].ToString(), 1);
            }

            return modWithValues;
        }

        public double GetAverage() {
            double total = 0;
            foreach (double val in values) {
                total += val;
            }
            return total / values.Count;
        }

        private void ParseString(string input) {

            // extract all the integer values from the input
            string pattern = @"\d+\.*\d*";
            Regex reg = new Regex(pattern);
            MatchCollection mc = reg.Matches(input);

            // set value to the average of ints in input
            foreach (Match match in mc) {
                values.Add(Double.Parse(match.Value));
            }

            //replace ints in input with #
            mod = Regex.Replace(input, pattern, "#");
        }
    }
}
