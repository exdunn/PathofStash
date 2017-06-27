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
        public List<object> values;

        public Property(string name)
        {
            this.name = name;
            values = new List<object>();
        }

        public String ToString(int indentSize)
        {
            String str = new string(' ', 4 * indentSize) + "name: " + name;
            if (values.Count() > 0)
            {
                str += "\n" + new string(' ', 4 * indentSize) + "value: " + values[0];
            }
            return str;
        }

        public void AddValue(string item)
        {
            values.Add(item);
        }

        public void RemoveValue(string item)
        {
            values.Remove(item);
        }

        public void RemoveValue(int index)
        {
            values.RemoveAt(index);
        }
    }
}
