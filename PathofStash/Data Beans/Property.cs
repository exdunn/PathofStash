using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathofStash
{
    public class Property
    {
        public string name { get; set; }
        public List<List<String>> values { get; set; }

        public Property(string name)
        {
            this.name = name;
            values = new List<List<String>>();
        }

        public String ToString(int indentSize)
        {
            String str = new string(' ', 4 * indentSize) + "name: " + name;
            if (values.Count() > 0)
            {
                str += "\n" + new string(' ', 4 * indentSize) + "value: " + values[0][0];
            }
            return str;
        }
    }
}
